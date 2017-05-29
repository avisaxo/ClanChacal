using UnityEngine;
using System.Collections;
using Firebase.Database;
using Firebase;
using Firebase.Unity.Editor;
using System.Linq;
using System.Collections.Generic;
using UnityEngine.UI;
using MaterialUI;

public class dataentry : MonoBehaviour {

	public static dataentry instance;
	public string email;
	public string password;
	public string Nick;
	public string Filename;
	public string Batallon;
	public string Faltas;
	public string Cibi;
	public string AutorizacionTipo;
	public string Fecha;
	public string Tipo;
	public string ProvaiderIDUser;
	public string Instruccion;
	public string RGranadero;
	public string RApoyo;
	public string RAt;
	public string RMedico;
	public string RTEscuadra;
	public string RTDesignado;
	public string RFrancotirador;
	public string RObservador;

	public string Amo1;
	public string Amo2;
	public string Amo3;
	public string Amo4;
	public string Amo5;
	public string Amo6;
	public string Amo7;
	public string Amo8;
	public string Desc1;
	public string Desc2;
	public string Desc3;
	public string Desc4;
	public string Desc5;
	public string Desc6;
	public string Desc7;
	public string Desc8;

	public string Ina1;
	public string Ina2;
	public string Ina3;
	public string Ina4;
	public string Ina5;
	public string Ina6;
	public string Ina7;
	public string Ina8;
	public string Ina9;
	public string Ina10;
	public string Descr1;
	public string Descr2;
	public string Descr3;
	public string Descr4;
	public string Descr5;
	public string Descr6;
	public string Descr7;
	public string Descr8;
	public string Descr9;
	public string Descr10;

	void Awake()
	{
		instance = this;
	}
	// Use this for initialization
	void Start () {
		FirebaseApp app = FirebaseApp.DefaultInstance;
		app.SetEditorDatabaseUrl ("https://clanchacal-9c46e.firebaseio.com/");
		if (app.Options.DatabaseUrl != null) {
			app.SetEditorDatabaseUrl (app.Options.DatabaseUrl);
		}
		FirebaseDatabase.DefaultInstance.GetReference("Jugadores").ValueChanged += (object sender2, ValueChangedEventArgs e2) => {
			List<DataSnapshot> d = e2.Snapshot.Children.ToList();
			int l = d.Count;
			for(int a=0; a < l; a++)
			{
				Debug.Log(d.ElementAt(a).Key.ToString());
			}
		};
		email = "";
		password = "";
		Nick = "";
		Batallon = "";
		Fecha = "";
		Tipo = "";
		Faltas = "0";
		Cibi = "No";
		Fecha = "";
		Filename = "";
		ProvaiderIDUser = "";
		AutorizacionTipo = "0";
		Instruccion = "No";
		RGranadero = "No";
		RApoyo = "No";
		RAt = "No";
		RMedico = "No";
		RTEscuadra = "No";
		RTDesignado = "No";
		RFrancotirador = "No";
		RObservador = "No";
		Amo1 = "No";
		Amo2 = "No";
		Amo3 = "No";
		Amo4 = "No";
		Amo5 = "No";
		Amo6 = "No";
		Amo7 = "No";
		Amo8 = "No";
		Desc1 = "Descripcion";
		Desc2 = "Descripcion";
		Desc3 = "Descripcion";
		Desc4 = "Descripcion";
		Desc5 = "Descripcion";
		Desc6 = "Descripcion";
		Desc7 = "Descripcion";
		Desc8 = "Descripcion";

		Ina1 = "No";
		Ina2 = "No";
		Ina3 = "No";
		Ina4 = "No";
		Ina5 = "No";
		Ina6 = "No";
		Ina7 = "No";
		Ina8 = "No";
		Ina9 = "No";
		Ina10 = "No";
		Descr1 = "Descripcion";
		Descr2 = "Descripcion";
		Descr3 = "Descripcion";
		Descr4 = "Descripcion";
		Descr5 = "Descripcion";
		Descr6 = "Descripcion";
		Descr7 = "Descripcion";
		Descr8 = "Descripcion";
		Descr9 = "Descripcion";
		Descr10 = "Descripcion";
	}

	public void CreateDB_New_Player ()
	{
		Debug.Log ("User = " + UserAuth.instance.user + " Nick = " + Nick);
		if (UserAuth.instance.user !=null) {
			//UserAuth.instance.UpdateUserProfile (Nick);
			Debug.Log ("Update player");
			DatabaseReference reference = FirebaseDatabase.DefaultInstance.GetReference ("Jugadores");
			reference=reference.Child (UserAuth.instance.user.UserId);
			reference.Child ("email").SetValueAsync(UserAuth.instance.user.Email);
			reference.Child ("nombre").SetValueAsync(Nick);
			reference.Child ("filename").SetValueAsync(Nick);
			reference.Child ("Batallon").SetValueAsync(Batallon);
			reference.Child ("Tipo").SetValueAsync(Tipo);
			reference.Child ("Fecha").SetValueAsync(Fecha);
			reference.Child ("faltas").SetValueAsync(Faltas);
			reference.Child ("cibi").SetValueAsync(Cibi);
			reference.Child ("userid").SetValueAsync(UserAuth.instance.user.UserId);
			reference.Child ("token").SetValueAsync(UserAuth.instance._usertoken);
			reference.Child ("amonestaciones").SetValueAsync(0);
			reference.Child ("autorizaciontipo").SetValueAsync(AutorizacionTipo);

			reference.Child ("instruccion").SetValueAsync(Instruccion);
			reference.Child ("rollgranadero").SetValueAsync(RGranadero);
			reference.Child ("rollapoyo").SetValueAsync(RApoyo);
			reference.Child ("rollat").SetValueAsync(RAt);
			reference.Child ("rollmedico").SetValueAsync(RMedico);
			reference.Child ("rolltiradoresc").SetValueAsync(RTEscuadra);
			reference.Child ("rolltiradordes").SetValueAsync(RTDesignado);
			reference.Child ("rollfrancotirador").SetValueAsync(RFrancotirador);
			reference.Child ("rollobservador").SetValueAsync(RFrancotirador);

			reference.Child ("Amonestar/Amon1").SetValueAsync(Amo1);
			reference.Child ("Amonestar/Amon2").SetValueAsync(Amo2);
			reference.Child ("Amonestar/Amon3").SetValueAsync(Amo3);
			reference.Child ("Amonestar/Amon4").SetValueAsync(Amo4);
			reference.Child ("Amonestar/Amon5").SetValueAsync(Amo5);
			reference.Child ("Amonestar/Amon6").SetValueAsync(Amo6);
			reference.Child ("Amonestar/Amon7").SetValueAsync(Amo7);
			reference.Child ("Amonestar/Amon8").SetValueAsync(Amo8);
			reference.Child ("Amonestar/Desc1").SetValueAsync(Desc1);
			reference.Child ("Amonestar/Desc2").SetValueAsync(Desc2);
			reference.Child ("Amonestar/Desc3").SetValueAsync(Desc3);
			reference.Child ("Amonestar/Desc4").SetValueAsync(Desc4);
			reference.Child ("Amonestar/Desc5").SetValueAsync(Desc5);
			reference.Child ("Amonestar/Desc6").SetValueAsync(Desc6);
			reference.Child ("Amonestar/Desc7").SetValueAsync(Desc7);
			reference.Child ("Amonestar/Desc8").SetValueAsync(Desc8);

			reference.Child ("Inasistencias/Ina1").SetValueAsync(Ina1);
			reference.Child ("Inasistencias/Ina2").SetValueAsync(Ina2);
			reference.Child ("Inasistencias/Ina3").SetValueAsync(Ina3);
			reference.Child ("Inasistencias/Ina4").SetValueAsync(Ina4);
			reference.Child ("Inasistencias/Ina5").SetValueAsync(Ina5);
			reference.Child ("Inasistencias/Ina6").SetValueAsync(Ina6);
			reference.Child ("Inasistencias/Ina7").SetValueAsync(Ina7);
			reference.Child ("Inasistencias/Ina8").SetValueAsync(Ina8);
			reference.Child ("Inasistencias/Ina9").SetValueAsync(Ina9);
			reference.Child ("Inasistencias/Ina10").SetValueAsync(Ina10);
			reference.Child ("Inasistencias/Descr1").SetValueAsync(Descr1);
			reference.Child ("Inasistencias/Descr2").SetValueAsync(Descr2);
			reference.Child ("Inasistencias/Descr3").SetValueAsync(Descr3);
			reference.Child ("Inasistencias/Descr4").SetValueAsync(Descr4);
			reference.Child ("Inasistencias/Descr5").SetValueAsync(Descr5);
			reference.Child ("Inasistencias/Descr6").SetValueAsync(Descr6);
			reference.Child ("Inasistencias/Descr7").SetValueAsync(Descr7);
			reference.Child ("Inasistencias/Descr8").SetValueAsync(Descr8);
			reference.Child ("Inasistencias/Descr9").SetValueAsync(Descr9);
			reference.Child ("Inasistencias/Descr10").SetValueAsync(Descr10);
		}
	}
}
