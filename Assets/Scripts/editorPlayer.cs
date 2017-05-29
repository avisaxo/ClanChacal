using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using Firebase.Database;

public class editorPlayer : GenericPopUp {
	public GameObject button;

	public string NombreST;
	public string PuestoST;
	public string UserID;
	public InputField Faltas;
	public InputField Amonestaciones;
	public InputField Autorizacion;
	public InputField NombreEdit;
	public InputField PuestoEdit;
	public Text InputTexNick;
	public Text InputTexBatallon;
	public Text TextFaltas;
	public Text TextAmonestaciones;
	public Text TextAutorizaciones;

	public string STFaltas;
	public string STAmonestaciones;
	public string STAutorizacion;

	public string FechaCibiST;
	public InputField FechaCibiIF;
	public Button AutomaticDateCibi;

	public string FechaInstST;
	public InputField FechaInstIF;
	public Button AutomaticDateInst;

	public InputField RollGranadero;
	public string RollGranaderoST;
	public Button AutomaticGranadero;

	public InputField RollAT;
	public string RollATST;
	public Button AutomaticAT;

	public InputField RollApoyo;
	public string RollApoyoST;
	public Button AutomaticApoyo;

	public InputField RollMedico;
	public string RollMedicoST;
	public Button AutomaticMedico;

	public InputField RollTEscuadra;
	public string RollTEscuadraST;
	public Button AutomaticTescuadra;

	public InputField RollTDesignado;
	public string RollTDesignadoST;
	public Button AutomaticTdesignado;

	public InputField RollTElite;
	public string RollTEliteST;
	public Button AutomaticTElite;

	public InputField RollObservador;
	public string RollObservadorST;
	public Button AutomaticObservador;

	public GameObject Jugadores;
	public GameObject GAmonestaciones;
	public GameObject GInasistencias;
	public DataSnapshot data;

	void Start () {
		button.SetActive(true);
		AutomaticDateCibi.gameObject.SetActive (true);
		AutomaticDateInst.gameObject.SetActive (true);
		CargaDatosPlayer ();
	}

	public void Reset()
	{
		button.SetActive(true);
		AutomaticDateCibi.gameObject.SetActive (true);
		AutomaticDateInst.gameObject.SetActive (true);

		AutomaticGranadero.gameObject.SetActive (true);
		AutomaticAT.gameObject.SetActive (true);
		AutomaticApoyo.gameObject.SetActive (true);
		AutomaticMedico.gameObject.SetActive (true);
		AutomaticTescuadra.gameObject.SetActive (true);
		AutomaticTdesignado.gameObject.SetActive (true);
		AutomaticTElite.gameObject.SetActive (true);
		AutomaticObservador.gameObject.SetActive (true);

		NombreST = "";
		PuestoST = "";
		UserID = "";
		Faltas.text = "";
		Amonestaciones.text = "";
		NombreEdit.text = "";
		PuestoEdit.text = "";

		STFaltas = "";
		STAmonestaciones = "";
		STAutorizacion = "";

		FechaCibiST = "";
		FechaCibiIF.text = "";

		FechaInstST = "";
		FechaInstIF.text = "";

		RollGranadero.text = "";
		RollGranaderoST = "";

		RollAT.text = "";
		RollATST = "";

		RollApoyo.text = "";
		RollApoyoST = "";

		RollMedico.text = "";
		RollMedicoST = "";

		RollTEscuadra.text = "";
		RollTEscuadraST = "";

		RollTDesignado.text = "";
		RollTDesignadoST = "";

		RollTElite.text = "";
		RollTEliteST = "";

		RollObservador.text = "";
		RollObservadorST = "";
	}

	public void SendValoration(){
		DatabaseReference reference = FirebaseDatabase.DefaultInstance.GetReference ("Jugadores");
		reference=reference.Child (UserID);
		NombreST = reference.Child ("nombre").SetValueAsync(NombreEdit.text).ToString();
		PuestoST = reference.Child ("Batallon").SetValueAsync(PuestoEdit.text).ToString();
		FechaCibiST = reference.Child ("cibi").SetValueAsync(FechaCibiIF.text).ToString();
		FechaInstST = reference.Child ("instruccion").SetValueAsync(FechaInstIF.text).ToString();

		RollGranaderoST = reference.Child ("rollgranadero").SetValueAsync(RollGranadero.text).ToString();
		RollApoyoST = reference.Child ("rollapoyo").SetValueAsync(RollApoyo.text).ToString();
		RollATST = reference.Child ("rollat").SetValueAsync(RollAT.text).ToString();
		RollMedicoST = reference.Child ("rollmedico").SetValueAsync(RollMedico.text).ToString();
		RollTEscuadraST = reference.Child ("rolltiradoresc").SetValueAsync(RollTEscuadra.text).ToString();
		RollTDesignadoST = reference.Child ("rolltiradordes").SetValueAsync(RollTDesignado.text).ToString();
		RollTEliteST = reference.Child ("rollfrancotirador").SetValueAsync(RollTElite.text).ToString();
		RollObservadorST = reference.Child ("rollobservador").SetValueAsync(RollObservador.text).ToString();

	//	UserID = GetComponent<eterplayer> ().userid;
	}

	public void ChangeDateEditor()
	{
		FechaCibiIF.text = System.DateTime.Now.ToString("dd/MM/yyyy");
		FechaCibiST = FechaCibiIF.text;
		AutomaticDateCibi.gameObject.SetActive (false);
	}

	public void ChangeDateEditorInst()
	{
		FechaInstIF.text = System.DateTime.Now.ToString("dd/MM/yyyy");
		FechaInstST = FechaInstIF.text;
		AutomaticDateInst.gameObject.SetActive (false);
	}

	public void ChangeEditorRollGranadero()
	{
		RollGranadero.text = System.DateTime.Now.ToString("dd/MM/yyyy");
		RollGranaderoST = RollGranadero.text;
		AutomaticGranadero.gameObject.SetActive (false);
	}

	public void ChangeEditorRollAt()
	{
		RollAT.text = System.DateTime.Now.ToString("dd/MM/yyyy");
		RollATST = RollAT.text;
		AutomaticAT.gameObject.SetActive (false);
	}

	public void ChangeEditorRollApoyo()
	{
		RollApoyo.text = System.DateTime.Now.ToString("dd/MM/yyyy");
		RollApoyoST = RollApoyo.text;
		AutomaticApoyo.gameObject.SetActive (false);
	}

	public void ChangeEditorRollMedico()
	{
		RollMedico.text = System.DateTime.Now.ToString("dd/MM/yyyy");
		RollMedicoST = RollMedico.text;
		AutomaticMedico.gameObject.SetActive (false);
	}

	public void ChangeEditorRollTescuadra()
	{
		RollTEscuadra.text = System.DateTime.Now.ToString("dd/MM/yyyy");
		RollTEscuadraST = RollTEscuadra.text;
		AutomaticTescuadra.gameObject.SetActive (false);
	}

	public void ChangeEditorRollTdesign()
	{
		RollTDesignado.text = System.DateTime.Now.ToString("dd/MM/yyyy");
		RollTDesignadoST = RollTDesignado.text;
		AutomaticTdesignado.gameObject.SetActive (false);
	}

	public void ChangeEditorRollTelite()
	{
		RollTElite.text = System.DateTime.Now.ToString("dd/MM/yyyy");
		RollTEliteST = RollTElite.text;
		AutomaticTElite.gameObject.SetActive (false);
	}

	public void ChangeEditorRollObservador()
	{
		RollObservador.text = System.DateTime.Now.ToString("dd/MM/yyyy");
		RollObservadorST = RollObservador.text;
		AutomaticObservador.gameObject.SetActive (false);
	}

	public void CargaDatosPlayer()
	{
		NombreEdit.text = NombreST;
		PuestoEdit.text = PuestoST;
		FechaCibiIF.text = FechaCibiST;
		FechaInstIF.text = FechaInstST;
		RollGranadero.text = RollGranaderoST;
		RollAT.text = RollATST;
		RollApoyo.text = RollApoyoST;
		RollMedico.text = RollMedicoST;
		RollTEscuadra.text = RollTEscuadraST;
		RollTDesignado.text = RollTDesignadoST;
		RollTElite.text = RollTEliteST;
		RollObservador.text = RollObservadorST;
	}

	public void CambiaNick()
	{
		string NombreAux = "";
		bool Active = false;
		for (int a = 0; a < NombreEdit.text.Length; a++) {
			if (NombreEdit.text [a] == '.') {
				Active = true;
			} else if (Active) {
				NombreAux = NombreAux + NombreEdit.text [a];
			}
		}
		string RangoNick = "";
		RangoNick = (InputTexNick.text + NombreAux);
		NombreEdit.text = RangoNick;
	}

	void OnEnable()
	{
		CargaDatosPlayer ();
		//SendValoration ();
	}

	public void CambiaBatallon()
	{
		string UnidadBatallon = (InputTexBatallon.text);
		PuestoEdit.text = UnidadBatallon;
	}

	public void SetActualData(){
		DatabaseReference reference = FirebaseDatabase.DefaultInstance.GetReference ("Jugadores");
		reference=reference.Child (UserID);
		reference.Child ("nombre").SetValueAsync(NombreEdit.text);
		reference.Child ("filename").SetValueAsync(NombreEdit.text);
		reference.Child ("Batallon").SetValueAsync(PuestoEdit.text);

		NombreST = "";
		PuestoST = "";

		Jugadores.GetComponent<etermaxplayers> ().InitializeFirebase ();
		//	button.SetActive(false);
	}
}
