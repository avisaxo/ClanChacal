using UnityEngine;
using System.Collections;
using Firebase;
using Firebase.Database;
using Firebase.Unity.Editor;
using System.Collections.Generic;
using UnityEngine.UI;

public class etermaxplayers : MonoBehaviour
{
	DependencyStatus dependencyStatus = DependencyStatus.UnavailableOther;
	ArrayList players;
	public GameObject playerprefab;
	public GameObject jugadores;
	public GameObject deselect;
	public GameObject Popup;
	public GameObject Perfil;
	public GameObject EditPlayers;
	public GameObject AmonestarPlayer;
	public GameObject InasistenciasPlayer;
	public GameObject UnidadA;
	public GameObject UnidadB;
	public GameObject UnidadC;
	public GameObject UnidadD;
	public GameObject UnidadE;
	public GameObject UnidadF;
	public GameObject UnidadG;
	public GameObject UnidadH;
	public string NumeroAutorizacionPlayer;
	public List<eterplayer> eterp = new List<eterplayer> ();
	public List<GameObject> lista = new List<GameObject> ();
	private string projectid = "https://clanchacal-9c46e.firebaseio.com/";

	public string AutorizacionTipo;


	void Start ()
	{
		dependencyStatus = FirebaseApp.CheckDependencies ();
		if (dependencyStatus != DependencyStatus.Available) {
			FirebaseApp.FixDependenciesAsync ().ContinueWith (task => {
				dependencyStatus = FirebaseApp.CheckDependencies ();
				if (dependencyStatus == DependencyStatus.Available) {
	//				DataSetPlayerActual();
					InitializeFirebase ();
				} else {
					Debug.LogError ("Could not resolve all Firebase dependencies: " + dependencyStatus);
				}
			});
		} else {
	//		DataSetPlayerActual ();
			InitializeFirebase ();
		}
		NumeroAutorizacionPlayer = "1";
	}

	public void SetPopUp (GameObject go)
	{
		Popup = go;
	}
	public string autorizacion;
	public void DataSetPlayerActual()
	{
		//Debug.Log ("Entra al Perfil " + UserAuth.instance.user);
		if (UserAuth.instance.user != null)
		{
			FirebaseDatabase.DefaultInstance.GetReference("Jugadores/"+UserAuth.instance.user.UserId).ValueChanged += (object sender2, ValueChangedEventArgs e2) => {
				Debug.Log ("UserId = " + UserAuth.instance.user.UserId);
				autorizacion=e2.Snapshot.Child("autorizaciontipo").Value.ToString();
				Debug.Log ("autorizacion = " + autorizacion);
				AutorizacionTipo = autorizacion;
				NumeroAutorizacionPlayer = autorizacion;
			};
		}
	}

	public void InitializeFirebase ()
	{
		Debug.Log ("Inicio Clan");
		FirebaseApp app = FirebaseApp.DefaultInstance;
		app.SetEditorDatabaseUrl (projectid);
		if (app.Options.DatabaseUrl != null) {
			app.SetEditorDatabaseUrl (app.Options.DatabaseUrl);
		}

		//players = new ArrayList ();
		FirebaseDatabase.DefaultInstance.GetReference ("Jugadores").OrderByChild ("nombre").ValueChanged += (object sender2, ValueChangedEventArgs e2) => {
			Debug.Log ("Entra a la funcion 1");
			if (lista.Count <= 0){
				if (e2.DatabaseError != null) {
					Debug.LogError (e2.DatabaseError.Message);
					return;
				}
				//	players.Clear ();
				if (e2.Snapshot != null && e2.Snapshot.ChildrenCount > 0) {
					Debug.Log ("Entra a la funcion 2");
					foreach (GameObject go in lista) {
						eterp.Remove (go.GetComponent<eterplayer> ());
						Destroy (go);
					}
					foreach (var childSnapshot in e2.Snapshot.Children) {
						Debug.Log ("Entra a la funcion 3");
						if (childSnapshot.Child ("nombre") == null	|| childSnapshot.Child ("nombre").Value == null) {
							Debug.LogError ("Bad data in sample.  Did you forget to call SetEditorDatabaseUrl with your project id?");
							break;
						} else {
							Debug.Log ("NumeroAutorizacionPlayer = " + NumeroAutorizacionPlayer);
							GameObject etpgo = (GameObject)Instantiate (playerprefab, jugadores.transform);
							eterplayer etp = etpgo.GetComponent<eterplayer> ();
							etpgo.GetComponent<eterplayer> ().puntuador = Popup.gameObject;
							etpgo.GetComponent<eterplayer> ().NumberPlayerAutorize = NumeroAutorizacionPlayer;
							etpgo.GetComponent<eterplayer> ().data = childSnapshot;
							etpgo.GetComponent<AbrePopupEdit> ().editPlayerPopup = EditPlayers;
							etpgo.GetComponent<AbrePopupEdit> ().amonestarPopup = AmonestarPlayer;
							etpgo.GetComponent<AbrePopupEdit> ().inasistenciasPopup = InasistenciasPlayer;

							etpgo.transform.localScale = Vector3.one;
							etp.puntuador = Popup;
							etp.SetData (childSnapshot);
							eterp.Add (etp);
							lista.Add (etpgo);
						}
					}
				}
			}
		};
	//	ReleeFirebase ();
	}

	public void ReleeFirebase ()
	{
		Debug.Log ("Inicio Clan");
		FirebaseApp app = FirebaseApp.DefaultInstance;
		app.SetEditorDatabaseUrl (projectid);
		if (app.Options.DatabaseUrl != null) {
			app.SetEditorDatabaseUrl (app.Options.DatabaseUrl);
		}
		FirebaseDatabase.DefaultInstance.GetReference ("Jugadores").OrderByChild ("nombre").ValueChanged += (object sender2, ValueChangedEventArgs e2) => {
			if (e2.Snapshot != null && e2.Snapshot.ChildrenCount > 0) {
				Debug.Log ("Entra a la funcion 2");
				int Indice = 0;
				foreach (var childSnapshot in e2.Snapshot.Children) {
					Debug.Log ("NumeroAutorizacionPlayer = " + NumeroAutorizacionPlayer);
					lista[Indice].GetComponent<eterplayer> ().puntuador = Popup.gameObject;
					lista[Indice].GetComponent<eterplayer> ().NumberPlayerAutorize = NumeroAutorizacionPlayer;
					lista[Indice].GetComponent<eterplayer> ().data = childSnapshot;
					lista[Indice].GetComponent<AbrePopupEdit>().editPlayerPopup = EditPlayers;
					lista[Indice].GetComponent<AbrePopupEdit>().amonestarPopup = AmonestarPlayer;
					lista[Indice].GetComponent<AbrePopupEdit>().inasistenciasPopup = InasistenciasPlayer;
					lista[Indice].transform.localScale=Vector3.one;
					lista[Indice].GetComponent<eterplayer>().puntuador = Popup;
					lista[Indice].GetComponent<eterplayer>().SetData (childSnapshot);
					Indice++;
				}
			}
		};
		UnidadA.GetComponent<playersUnidad> ().InitializeFirebase ();
		UnidadB.GetComponent<playersUnidad> ().InitializeFirebase ();
		UnidadC.GetComponent<playersUnidad> ().InitializeFirebase ();
		UnidadD.GetComponent<playersUnidad> ().InitializeFirebase ();
		UnidadE.GetComponent<playersUnidad> ().InitializeFirebase ();
		UnidadF.GetComponent<playersUnidad> ().InitializeFirebase ();
		UnidadG.GetComponent<playersUnidad> ().InitializeFirebase ();
		UnidadH.GetComponent<playersUnidad> ().InitializeFirebase ();
	}



	public void Buscar (string searchtext)
	{
		searchtext = searchtext.ToLower ();
		foreach (eterplayer etp in eterp) {
			if (etp.nombre.Contains (searchtext)) {
				etp.gameObject.transform.SetParent (jugadores.transform);
				continue;
			}
			if (etp.posicion.Contains (searchtext)) {
				etp.gameObject.transform.SetParent (jugadores.transform);
				continue;
			}
			etp.gameObject.transform.SetParent (deselect.transform);
		}
	}


}
