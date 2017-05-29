using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using Firebase.Database;
using Firebase;
using Firebase.Unity.Editor;

public class Perfil : MonoBehaviour {
	public Text nombre;
	public Text batallon;
	public Text amonestaciones;

	public Text StringIngreso;
	public Text StringInstruccion;
	public Text StringCibi;
	public Text StringRollGranadero;
	public Text StringRollAT;
	public Text StringRollApoyo;
	public Text StringRollMedico;
	public Text StringRollTiradorEsc;
	public Text StringRollTiradorDes;
	public Text StringRollFrancortirador;

	//public Text token;
	public GameObject BaseJugadores;
	// Use this for initialization
	void Start(){
		Debug.Log ("Entra al Star del Perfil");
		FirebaseApp app = FirebaseApp.DefaultInstance;
		app.SetEditorDatabaseUrl ("https://clanchacal-9c46e.firebaseio.com/");

		if (app.Options.DatabaseUrl != null) {
			app.SetEditorDatabaseUrl (app.Options.DatabaseUrl);
		}
	}

	void OnEnable ()
	{
		Debug.Log ("Entra al Perfil " + UserAuth.instance.user);
		if (UserAuth.instance.user != null)
		{
			FirebaseDatabase.DefaultInstance.GetReference("Jugadores/"+UserAuth.instance.user.UserId).ValueChanged += (object sender2, ValueChangedEventArgs e2) => {
				Debug.Log ("Carga Base");
				nombre.text=e2.Snapshot.Child("nombre").Value.ToString();
				batallon.text=e2.Snapshot.Child("Batallon").Value.ToString();
				amonestaciones.text =e2.Snapshot.Child("amonestaciones").Value.ToString();
			
				StringIngreso.text=e2.Snapshot.Child("Fecha").Value.ToString();
				StringInstruccion.text=e2.Snapshot.Child("instruccion").Value.ToString();
				StringCibi.text=e2.Snapshot.Child("cibi").Value.ToString();
				StringRollGranadero.text=e2.Snapshot.Child("rollgranadero").Value.ToString();
				StringRollAT.text=e2.Snapshot.Child("rollat").Value.ToString();
				StringRollApoyo.text=e2.Snapshot.Child("rollapoyo").Value.ToString();
				StringRollMedico.text=e2.Snapshot.Child("rollmedico").Value.ToString();
				StringRollTiradorEsc.text=e2.Snapshot.Child("rolltiradoresc").Value.ToString();
				StringRollTiradorDes.text=e2.Snapshot.Child("rolltiradordes").Value.ToString();
				StringRollFrancortirador.text=e2.Snapshot.Child("rollfrancotirador").Value.ToString();

				Debug.Log ("StringRollGranadero = " + StringRollGranadero.text);
				Debug.Log ("StringRollAT = " + StringRollAT.text);
				Debug.Log ("StringRollApoyo = " + StringRollApoyo.text);
				Debug.Log ("StringRollMedico = " + StringRollMedico.text);
				Debug.Log ("StringRollTiradorEsc = " + StringRollTiradorEsc.text);
				Debug.Log ("StringRollTiradorDes = " + StringRollTiradorDes.text);
				Debug.Log ("StringRollFrancortirador = " + StringRollFrancortirador.text);
	    	};
		}
	}

	public void LogOut ()
	{
		UserAuth.instance.SignOut ();
		Application.Quit ();
	}
}
