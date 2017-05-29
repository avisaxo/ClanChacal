﻿using Firebase;
using Firebase.Database;
using Firebase.Unity.Editor;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

// Handler for UI buttons on the scene.  Also performs some
// necessary setup (initializing the firebase app, etc) on
// startup.
public class firebasetest : MonoBehaviour {

		ArrayList leaderBoard;
		Vector2 scrollPosition = Vector2.zero;
		private Vector2 controlsScrollViewVector = Vector2.zero;
		private string projectid="https://clanchacal-9c46e.firebaseio.com/";
		public GUISkin fb_GUISkin;

		private const int MaxScores = 5;
		private string logText = "";
		private string email = "";
		private int score = 100;
		private Vector2 scrollViewVector = Vector2.zero;
		bool UIEnabled = true;

		const int kMaxLogSize = 16382;
		DependencyStatus dependencyStatus = DependencyStatus.UnavailableOther;

		// When the app starts, check to make sure that we have
		// the required dependencies to use Firebase, and if not,
		// add them if possible.
		void Start() {
				dependencyStatus = FirebaseApp.CheckDependencies();
				if (dependencyStatus != DependencyStatus.Available) {
						FirebaseApp.FixDependenciesAsync().ContinueWith(task => {
								dependencyStatus = FirebaseApp.CheckDependencies();
								if (dependencyStatus == DependencyStatus.Available) {
										InitializeFirebase();
								} else {
										Debug.LogError(
												"Could not resolve all Firebase dependencies: " + dependencyStatus);
								}
						});
				} else {
						InitializeFirebase();
				}
		}

		// Initialize the Firebase database:
		void InitializeFirebase() {
				FirebaseApp app = FirebaseApp.DefaultInstance;
				app.SetEditorDatabaseUrl(projectid);
				if (app.Options.DatabaseUrl != null){
						app.SetEditorDatabaseUrl(app.Options.DatabaseUrl);
				}

				leaderBoard = new ArrayList();
				leaderBoard.Add("CANCHAS");
				FirebaseDatabase.DefaultInstance
						.GetReference("Fields")
						.ValueChanged += (object sender2, ValueChangedEventArgs e2) => {
						if (e2.DatabaseError != null) {
								Debug.LogError(e2.DatabaseError.Message);
								return;
						}
						string title = leaderBoard[0].ToString();
						leaderBoard.Clear();
						leaderBoard.Add(title);
						if (e2.Snapshot != null && e2.Snapshot.ChildrenCount > 0) {
								foreach (var childSnapshot in e2.Snapshot.Children) {
										if (childSnapshot.Child("Nombre") == null
												|| childSnapshot.Child("Nombre").Value == null) {
												Debug.LogError("Bad data in sample.  Did you forget to call SetEditorDatabaseUrl with your project id?");
												break;
										} else {
												leaderBoard.Insert(1, childSnapshot.Child("Nombre").Value.ToString()
														+ "  " + childSnapshot.Child("Telefono").Value.ToString());
										}
								}
						}
				};
		}

		// Exit if escape (or back, on mobile) is pressed.
		void Update() {
				if (Input.GetKeyDown(KeyCode.Escape)) {
						Application.Quit();
				}
		}

		// Output text to the debug log text field, as well as the console.
		public void DebugLog(string s) {
				Debug.Log(s);
				logText += s + "\n";

				while (logText.Length > kMaxLogSize) {
						int index = logText.IndexOf("\n");
						logText = logText.Substring(index + 1);
				}

				scrollViewVector.y = int.MaxValue;
		}

		// A realtime database transaction receives MutableData which can be modified
		// and returns a TransactionResult which is either TransactionResult.Success(data) with
		// modified data or TransactionResult.Abort() which stops the transaction with no changes.
		TransactionResult AddScoreTransaction(MutableData mutableData) {
				List<object> leaders = mutableData.Value as List<object>;

				if (leaders == null) {
						leaders = new List<object>();
				} else if (mutableData.ChildrenCount >= MaxScores) {
						// If the current list of scores is greater or equal to our maximum allowed number,
						// we see if the new score should be added and remove the lowest existing score.
						long minScore = long.MaxValue;
						object minVal = null;
						foreach (var child in leaders) {
								if (!(child is Dictionary<string, object>))
										continue;
								long childScore = (long)((Dictionary<string, object>)child)["score"];
								if (childScore < minScore) {
										minScore = childScore;
										minVal = child;
								}
						}
						// If the new score is lower than the current minimum, we abort.
						if (minScore > score) {
								return TransactionResult.Abort();
						}
						// Otherwise, we remove the current lowest to be replaced with the new score.
						leaders.Remove(minVal);
				}

				// Now we add the new score as a new entry that contains the email address and score.
				Dictionary<string, object> newScoreMap = new Dictionary<string, object>();
				newScoreMap["score"] = score;
				newScoreMap["email"] = email;
				leaders.Add(newScoreMap);

				// You must set the Value to indicate data at that location has changed.
				mutableData.Value = leaders;
				return TransactionResult.Success(mutableData);
		}

		public void AddScore() {
				if (score == 0 || string.IsNullOrEmpty(email)) {
						DebugLog("invalid score or email.");
						return;
				}
				DebugLog(String.Format("Attempting to add score {0} {1}",
						email, score.ToString()));

				DatabaseReference reference = FirebaseDatabase.DefaultInstance.GetReference("Leaders");

				DebugLog("Running Transaction...");
				// Use a transaction to ensure that we do not encounter issues with
				// simultaneous updates that otherwise might create more than MaxScores top scores.
				reference.RunTransaction(AddScoreTransaction)
						.ContinueWith(task => {
								if (task.Exception != null) {
										DebugLog(task.Exception.ToString());
								} else if (task.IsCompleted) {
										DebugLog("Transaction complete.");
								}
						});
		}


		// Render the GUI:
		void OnGUI() {
				GUI.skin=fb_GUISkin;
				GUILayout.BeginVertical(GUILayout.MinWidth(Screen.width));
				foreach(string st in leaderBoard){
						GUILayout.Button(st,GUILayout.MinHeight(Screen.height/10));
				}
				GUILayout.EndVertical();
		}
}