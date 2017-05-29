using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Signin : MonoBehaviour {

	public string email;
	public string password;
	public string Nick;
	public string Batallon;
	public string Fecha;
	public string Tipo;
	public GameObject Jugadores;
	public InputField inputNick;
	public InputField inputFecha;
	public Text InputTexNick;

	public InputField inputBatallon;
	public Text InputTexBatallon;

	public InputField inputTipo;
	public Text InputTexTipo;

	public void Awake()
	{
		inputTipo.text = "Fusilero";
		Fecha = System.DateTime.Now.ToString("dd/MM/yyyy");
		inputFecha.text = Fecha;
	}

	public void SignIn(){
		Debug.LogWarning ("SignIn");	
		dataentry.instance.email = email;
		dataentry.instance.password = password;
		dataentry.instance.Nick = Nick;
		dataentry.instance.Tipo = "Fusilero";
		dataentry.instance.Fecha = Fecha;
		dataentry.instance.Batallon = Batallon;
		UserAuth.instance.CreateUserWithEmail (email, password, "nombre");
	}

	public void CambiaNick()
	{
		/*string RangoNick = "";
		RangoNick = (InputTexNick.text + inputNick.text);
		inputNick.text = RangoNick;
		Nick = RangoNick;*/


		string NombreAux = "";
		string NombreAux1 = "";
		bool Active = false;
		NombreAux = InputTexNick.text + inputNick.text;
		for (int a = 0; a < NombreAux.Length; a++) {
			if (NombreAux [a] == '.') {
				Active = true;
				NombreAux1 = "";
			} else if (Active) {
				NombreAux1 += ("" + NombreAux[a]);
			}
		}
		string RangoNick = "";
		RangoNick = (InputTexNick.text + NombreAux1);
		inputNick.text = RangoNick;
		Nick = RangoNick;
	}

	public void CambiaBatallon()
	{
		string UnidadBatallon = (InputTexBatallon.text);
		inputBatallon.text = UnidadBatallon;
	}

	public void CambiaTipo()
	{
		string RangoTipo = (InputTexTipo.text);
		inputTipo.text = "Fusilero";
	}

	public void changeemail(string st){
			email = st;
	}

	public void changepassword(string st){
			password = st;
	}

	public void changeNick(string st){
		Nick = st;
	}

	public void changeBatallon(string st){
		Batallon = st;
	}

	public void changeFecha(string st){
		Fecha = st;
	}

	public void changeTipo(string st){
		Tipo = st;
	}

	public void ExitPopup()
	{
		gameObject.SetActive (false);
	}
}
