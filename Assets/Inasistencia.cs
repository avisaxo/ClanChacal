using UnityEngine;
using System.Collections;
using Firebase;
using Firebase.Database;
using Firebase.Unity.Editor;
using System.Collections.Generic;
using UnityEngine.UI;

public class Inasistencia : GenericPopUp {
	
	public string Fecha1ST;
	public InputField Fecha1IF;
	public Button AutomaticDate1;

	public string Fecha2ST;
	public InputField Fecha2IF;
	public Button AutomaticDate2;

	public string Fecha3ST;
	public InputField Fecha3IF;
	public Button AutomaticDate3;

	public string Fecha4ST;
	public InputField Fecha4IF;
	public Button AutomaticDate4;

	public string Fecha5ST;
	public InputField Fecha5IF;
	public Button AutomaticDate5;

	public string Fecha6ST;
	public InputField Fecha6IF;
	public Button AutomaticDate6;

	public string Fecha7ST;
	public InputField Fecha7IF;
	public Button AutomaticDate7;

	public string Fecha8ST;
	public InputField Fecha8IF;
	public Button AutomaticDate8;

	public string Fecha9ST;
	public InputField Fecha9IF;
	public Button AutomaticDate9;

	public string Fecha10ST;
	public InputField Fecha10IF;
	public Button AutomaticDate10;

	public Text Description1;
	public Text Description2;
	public Text Description3;
	public Text Description4;
	public Text Description5;
	public Text Description6;
	public Text Description7;
	public Text Description8;
	public Text Description9;
	public Text Description10;

	public string UserID;

	public void Awake()
	{
		/*Fecha1ST = "No";
		Fecha2ST = "No";
		Fecha3ST = "No";
		Fecha4ST = "No";
		Fecha5ST = "No";
		Fecha6ST = "No";
		Fecha7ST = "No";
		Fecha8ST = "No";
		Fecha9ST = "No";
		Fecha10ST = "No";*/
	}

	public void Start()
	{
		CargaDatos ();
	}

	public void CargaDatos()
	{
		Fecha1IF.text = Fecha1ST;
		Fecha2IF.text = Fecha2ST;
		Fecha3IF.text = Fecha3ST;
		Fecha4IF.text = Fecha4ST;
		Fecha5IF.text = Fecha5ST;
		Fecha6IF.text = Fecha6ST;
		Fecha7IF.text = Fecha7ST;
		Fecha8IF.text = Fecha8ST;
		Fecha9IF.text = Fecha9ST;
		Fecha10IF.text = Fecha10ST;
	}

	public void SendValoration(){
		DatabaseReference reference = FirebaseDatabase.DefaultInstance.GetReference ("Jugadores");
		reference=reference.Child (UserID);
		Fecha1ST = reference.Child ("Inasistencias/Ina1").SetValueAsync(Fecha1IF.text).ToString();
		Fecha2ST = reference.Child ("Inasistencias/Ina2").SetValueAsync(Fecha2IF.text).ToString();
		Fecha3ST = reference.Child ("Inasistencias/Ina3").SetValueAsync(Fecha3IF.text).ToString();
		Fecha4ST = reference.Child ("Inasistencias/Ina4").SetValueAsync(Fecha4IF.text).ToString();
		Fecha5ST = reference.Child ("Inasistencias/Ina5").SetValueAsync(Fecha5IF.text).ToString();
		Fecha6ST = reference.Child ("Inasistencias/Ina6").SetValueAsync(Fecha6IF.text).ToString();
		Fecha7ST = reference.Child ("Inasistencias/Ina7").SetValueAsync(Fecha7IF.text).ToString();
		Fecha8ST = reference.Child ("Inasistencias/Ina8").SetValueAsync(Fecha8IF.text).ToString();
		Fecha9ST = reference.Child ("Inasistencias/Ina9").SetValueAsync(Fecha9IF.text).ToString();
		Fecha10ST = reference.Child ("Inasistencias/Ina10").SetValueAsync(Fecha10IF.text).ToString();
		Description1.text = reference.Child ("Inasistencias/Descr1").SetValueAsync(Description1.text).ToString();
		Description2.text = reference.Child ("Inasistencias/Descr2").SetValueAsync(Description2.text).ToString();
		Description3.text = reference.Child ("Inasistencias/Descr3").SetValueAsync(Description3.text).ToString();
		Description4.text = reference.Child ("Inasistencias/Descr4").SetValueAsync(Description4.text).ToString();
		Description5.text = reference.Child ("Inasistencias/Descr5").SetValueAsync(Description5.text).ToString();
		Description6.text = reference.Child ("Inasistencias/Descr6").SetValueAsync(Description6.text).ToString();
		Description7.text = reference.Child ("Inasistencias/Descr7").SetValueAsync(Description7.text).ToString();
		Description8.text = reference.Child ("Inasistencias/Descr8").SetValueAsync(Description8.text).ToString();
		Description9.text = reference.Child ("Inasistencias/Descr9").SetValueAsync(Description9.text).ToString();
		Description10.text = reference.Child ("Inasistencias/Descr10").SetValueAsync(Description10.text).ToString();
	}

	public void ReseteaTodosValores()
	{
		Fecha1ST = "No";
		Fecha1IF.text = Fecha1ST;
		AutomaticDate1.gameObject.SetActive (true);
		Description1.text = "Descripcion";
		Fecha2IF.text = "No";
		Fecha2ST = Fecha2IF.text;
		AutomaticDate2.gameObject.SetActive (true);
		Description2.text = "Descripcion";
		Fecha3IF.text = "No";
		Fecha3ST = Fecha3IF.text;
		AutomaticDate3.gameObject.SetActive (true);
		Description3.text = "Descripcion";
		Fecha4IF.text = "No";
		Fecha4ST = Fecha4IF.text;
		AutomaticDate4.gameObject.SetActive (true);
		Description4.text = "Descripcion";
		Fecha5IF.text = "No";
		Fecha5ST = Fecha5IF.text;
		AutomaticDate5.gameObject.SetActive (true);
		Description5.text = "Descripcion";
		Fecha6IF.text = "No";
		Fecha6ST = Fecha6IF.text;
		AutomaticDate6.gameObject.SetActive (true);
		Description6.text = "Descripcion";
		Fecha7IF.text = "No";
		Fecha7ST = Fecha7IF.text;
		AutomaticDate7.gameObject.SetActive (true);
		Description7.text = "Descripcion";
		Fecha8IF.text = "No";
		Fecha8ST = Fecha8IF.text;
		AutomaticDate8.gameObject.SetActive (true);
		Description8.text = "Descripcion";
		Fecha9IF.text = "No";
		Fecha9ST = Fecha9IF.text;
		AutomaticDate9.gameObject.SetActive (true);
		Description9.text = "Descripcion";
		Fecha10IF.text = "No";
		Fecha10ST = Fecha10IF.text;
		AutomaticDate10.gameObject.SetActive (true);
		Description10.text = "Descripcion";
	}

	public void ChangeFecha1()
	{
		Fecha1IF.text = System.DateTime.Now.ToString("dd/MM/yyyy");
		Fecha1ST = Fecha1IF.text;
		AutomaticDate1.gameObject.SetActive (false);
	}
	public void ChangeFecha2()
	{
		Fecha2IF.text = System.DateTime.Now.ToString("dd/MM/yyyy");
		Fecha2ST = Fecha2IF.text;
		AutomaticDate2.gameObject.SetActive (false);
	}
	public void ChangeFecha3()
	{
		Fecha3IF.text = System.DateTime.Now.ToString("dd/MM/yyyy");
		Fecha3ST = Fecha3IF.text;
		AutomaticDate3.gameObject.SetActive (false);
	}
	public void ChangeFecha4()
	{
		Fecha4IF.text = System.DateTime.Now.ToString("dd/MM/yyyy");
		Fecha4ST = Fecha4IF.text;
		AutomaticDate4.gameObject.SetActive (false);
	}
	public void ChangeFecha5()
	{
		Fecha5IF.text = System.DateTime.Now.ToString("dd/MM/yyyy");
		Fecha5ST = Fecha5IF.text;
		AutomaticDate5.gameObject.SetActive (false);
	}
	public void ChangeFecha6()
	{
		Fecha6IF.text = System.DateTime.Now.ToString("dd/MM/yyyy");
		Fecha6ST = Fecha6IF.text;
		AutomaticDate6.gameObject.SetActive (false);
	}
	public void ChangeFecha7()
	{
		Fecha7IF.text = System.DateTime.Now.ToString("dd/MM/yyyy");
		Fecha7ST = Fecha7IF.text;
		AutomaticDate7.gameObject.SetActive (false);
	}
	public void ChangeFecha8()
	{
		Fecha8IF.text = System.DateTime.Now.ToString("dd/MM/yyyy");
		Fecha8ST = Fecha8IF.text;
		AutomaticDate8.gameObject.SetActive (false);
	}
	public void ChangeFecha9()
	{
		Fecha9IF.text = System.DateTime.Now.ToString("dd/MM/yyyy");
		Fecha9ST = Fecha9IF.text;
		AutomaticDate9.gameObject.SetActive (false);
	}
	public void ChangeFecha10()
	{
		Fecha10IF.text = System.DateTime.Now.ToString("dd/MM/yyyy");
		Fecha10ST = Fecha10IF.text;
		AutomaticDate10.gameObject.SetActive (false);
	}
}
