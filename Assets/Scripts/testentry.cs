using UnityEngine;
using System.Collections;
using Firebase.Database;
using Firebase;
using Firebase.Unity.Editor;
using System.Linq;
using System.Collections.Generic;
using UnityEngine.UI;
using MaterialUI;

public class testentry : MonoBehaviour {

	public static testentry instance;
	public string email;
	public string password;
	public string Nick;
	public string Batallon;
	public string Fecha;
	public string Tipo;
	public string ProvaiderIDUser;

	void Awake()
	{
		instance = this;
	}
	// Use this for initialization
	void Start () {
		Debug.Log ("Update player");
		FirebaseApp app = FirebaseApp.DefaultInstance;
		app.SetEditorDatabaseUrl ("https://clanchacal-9c46e.firebaseio.com/");
		if (app.Options.DatabaseUrl != null) {
			app.SetEditorDatabaseUrl (app.Options.DatabaseUrl);
		}
		DatabaseReference reference = FirebaseDatabase.DefaultInstance.GetReference ("Jugadores");
		reference.Child ("nombre").SetValueAsync ("Rct.Aries");
		reference.Child ("Batallon").SetValueAsync ("Foxtror");
		reference.Child ("Tipo").SetValueAsync ("Fusilera");
		reference.Child ("autorizaciontipo").SetValueAsync ("0");
	}
}
