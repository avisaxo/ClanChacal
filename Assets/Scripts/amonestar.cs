using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using Firebase.Database;

public class amonestar : GenericPopUp {
	
	public InputField Amonest1;
	public string Amonest1ST;
	public Button Amonest1Button;

	public InputField Amonest2;
	public string Amonest2ST;
	public Button Amonest2Button;

	public InputField Amonest3;
	public string Amonest3ST;
	public Button Amonest3Button;

	public InputField Amonest4;
	public string Amonest4ST;
	public Button Amonest4Button;

	public InputField Amonest5;
	public string Amonest5ST;
	public Button Amonest5Button;

	public InputField Amonest6;
	public string Amonest6ST;
	public Button Amonest6Button;

	public InputField Amonest7;
	public string Amonest7ST;
	public Button Amonest7Button;

	public InputField Amonest8;
	public string Amonest8ST;
	public Button Amonest8Button;

	public Text Description1;
	public Text Description2;
	public Text Description3;
	public Text Description4;
	public Text Description5;
	public Text Description6;
	public Text Description7;
	public Text Description8;

	public string UserID;

	void Start ()
	{
		CargaDatosPlayer ();
	}

	public void CargaDatosPlayer()
	{
		Amonest1.text = Amonest1ST;
		Amonest2.text = Amonest2ST;
		Amonest3.text = Amonest3ST;
		Amonest4.text = Amonest4ST;
		Amonest5.text = Amonest5ST;
		Amonest6.text = Amonest6ST;
		Amonest7.text = Amonest7ST;
		Amonest8.text = Amonest8ST;
	}

	public void SendValoration(){
		DatabaseReference reference = FirebaseDatabase.DefaultInstance.GetReference ("Jugadores");
		reference=reference.Child (UserID);
		Amonest1ST = reference.Child ("Amonestar/Amon1").SetValueAsync(Amonest1.text).ToString();
		Amonest2ST = reference.Child ("Amonestar/Amon2").SetValueAsync(Amonest2.text).ToString();
		Amonest3ST = reference.Child ("Amonestar/Amon3").SetValueAsync(Amonest3.text).ToString();
		Amonest4ST = reference.Child ("Amonestar/Amon4").SetValueAsync(Amonest4.text).ToString();
		Amonest5ST = reference.Child ("Amonestar/Amon5").SetValueAsync(Amonest5.text).ToString();
		Amonest6ST = reference.Child ("Amonestar/Amon6").SetValueAsync(Amonest6.text).ToString();
		Amonest7ST = reference.Child ("Amonestar/Amon7").SetValueAsync(Amonest7.text).ToString();
		Amonest8ST = reference.Child ("Amonestar/Amon8").SetValueAsync(Amonest8.text).ToString();
		Description1.text = reference.Child ("Amonestar/Desc1").SetValueAsync(Description1.text).ToString();
		Description2.text = reference.Child ("Amonestar/Desc2").SetValueAsync(Description2.text).ToString();
		Description3.text = reference.Child ("Amonestar/Desc3").SetValueAsync(Description3.text).ToString();
		Description4.text = reference.Child ("Amonestar/Desc4").SetValueAsync(Description4.text).ToString();
		Description5.text = reference.Child ("Amonestar/Desc5").SetValueAsync(Description5.text).ToString();
		Description6.text = reference.Child ("Amonestar/Desc6").SetValueAsync(Description6.text).ToString();
		Description7.text = reference.Child ("Amonestar/Desc7").SetValueAsync(Description7.text).ToString();
		Description8.text = reference.Child ("Amonestar/Desc8").SetValueAsync(Description8.text).ToString();

		//	UserID = GetComponent<eterplayer> ().userid;
	}

	public void ReseteaTodo()
	{
		Amonest1ST = "No";
		Amonest1.text = Amonest1ST;
		Amonest1Button.gameObject.SetActive (true);
		Description1.text = "Descripcion";
		Amonest2.text = "No";
		Amonest2ST = Amonest2.text;
		Amonest2Button.gameObject.SetActive (true);
		Description2.text = "Descripcion";
		Amonest3.text = "No";
		Amonest3ST = Amonest3.text;
		Amonest3Button.gameObject.SetActive (true);
		Description3.text = "Descripcion";
		Amonest4.text = "No";
		Amonest4ST = Amonest4.text;
		Amonest4Button.gameObject.SetActive (true);
		Description4.text = "Descripcion";
		Amonest5.text = "No";
		Amonest5ST = Amonest5.text;
		Amonest5Button.gameObject.SetActive (true);
		Description5.text = "Descripcion";
	}
	public void ReseteaTodosValores()
	{
		Amonest1ST = "No";
		Amonest1.text = Amonest1ST;
		Amonest1Button.gameObject.SetActive (true);
		Description1.text = "Descripcion";
		Amonest2.text = "No";
		Amonest2ST = Amonest2.text;
		Amonest2Button.gameObject.SetActive (true);
		Description2.text = "Descripcion";
		Amonest3.text = "No";
		Amonest3ST = Amonest3.text;
		Amonest3Button.gameObject.SetActive (true);
		Description3.text = "Descripcion";
		Amonest4.text = "No";
		Amonest4ST = Amonest4.text;
		Amonest4Button.gameObject.SetActive (true);
		Description4.text = "Descripcion";
		Amonest5.text = "No";
		Amonest5ST = Amonest5.text;
		Amonest5Button.gameObject.SetActive (true);
		Description5.text = "Descripcion";
		ResetAmon6 ();
		ResetAmon7 ();
		ResetAmon8 ();
	}

	public void ResetAmon6()
	{
		Amonest6.text = "No";
		Amonest6ST = Amonest6.text;
		Amonest6Button.gameObject.SetActive (true);
		Description6.text = "Descripcion";
	}
	public void ResetAmon7()
	{
		Amonest7.text = "No";
		Amonest7ST = Amonest7.text;
		Amonest7Button.gameObject.SetActive (true);
		Description7.text = "Descripcion";
	}
	public void ResetAmon8()
	{
		Amonest8.text = "No";
		Amonest8ST = Amonest8.text;
		Amonest8Button.gameObject.SetActive (true);
		Description8.text = "Descripcion";
	}

	public void ChangeAmonest1()
	{
		Amonest1.text = System.DateTime.Now.ToString("dd/MM/yyyy");
		Amonest1ST = Amonest1.text;
		Amonest1Button.gameObject.SetActive (false);
	}
	public void ChangeAmonest2()
	{
		Amonest2.text = System.DateTime.Now.ToString("dd/MM/yyyy");
		Amonest2ST = Amonest2.text;
		Amonest2Button.gameObject.SetActive (false);
	}
	public void ChangeAmonest3()
	{
		Amonest3.text = System.DateTime.Now.ToString("dd/MM/yyyy");
		Amonest3ST = Amonest3.text;
		Amonest3Button.gameObject.SetActive (false);
	}
	public void ChangeAmonest4()
	{
		Amonest4.text = System.DateTime.Now.ToString("dd/MM/yyyy");
		Amonest4ST = Amonest4.text;
		Amonest4Button.gameObject.SetActive (false);
	}
	public void ChangeAmonest5()
	{
		Amonest5.text = System.DateTime.Now.ToString("dd/MM/yyyy");
		Amonest5ST = Amonest5.text;
		Amonest5Button.gameObject.SetActive (false);
	}
	public void ChangeAmonest6()
	{
		Amonest6.text = System.DateTime.Now.ToString("dd/MM/yyyy");
		Amonest6ST = Amonest6.text;
		Amonest6Button.gameObject.SetActive (false);
	}
	public void ChangeAmonest7()
	{
		Amonest7.text = System.DateTime.Now.ToString("dd/MM/yyyy");
		Amonest7ST = Amonest7.text;
		Amonest7Button.gameObject.SetActive (false);
	}
	public void ChangeAmonest8()
	{
		Amonest8.text = System.DateTime.Now.ToString("dd/MM/yyyy");
		Amonest8ST = Amonest8.text;
		Amonest8Button.gameObject.SetActive (false);
	}
}
