using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using Firebase.Database;
using System.IO;

public class eterplayer : MonoBehaviour {

	public Image _image;
	public Text _name;
	public Text _posicion;
	public string nombre;
	public string posicion;
	public string fechaCibi;
	public string fechaInst;

	public string rollGranadero;
	public string rollApoyo;
	public string rollAt;
	public string rollMedico;
	public string rollTesc;
	public string rollTdes;
	public string rollTelite;
	public string rollObservador;

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


	public Text _autorize;
	public string autorize;
	private string url;
	private string filename;
	public GameObject puntuador;
	public RectTransform recttransform;
	public string Faltas;
	public string userid;
	public Button _edit;
	public GameObject Perfil;
	public string NumberPlayerAutorize;

	public Color[] _colors;
	public Color _color0;
	public Color _color1;
	public Color _color2;
	public Color _color3;
	public Color _color4;
	public Color _color5;
	public Color _color6;
	public Color _color7;
	public Color _color8;
	public Color _color9;

	public Sprite[] _images;
	public Sprite _foxtrot;
	public Sprite _alfa;
	public Sprite _shield;
	public Sprite _aguila;
	public Sprite _martillo;
	public Sprite _zerozulu;
	public Sprite _deltagolf;
	public Sprite _hoplita;

	public Sprite[] _Rangos;
	public Sprite _Rct;
	public Sprite _Sdo;
	public Sprite _Sdo1;
	public Sprite _Cbo;
	public Sprite _Cbo1;
	public Sprite _Sgt;
	public Sprite _Sgt1;
	public Sprite _Alfz;
	public Sprite _Tte;
	public Sprite _Cpt;

	public Image rango;

	public Image _Generic;

	public DataSnapshot data;

	public void SetData (DataSnapshot child)
	{
		_colors = new Color[10];
		_colors [0] = _color0;
		_colors [1] = _color1;
		_colors [2] = _color2;
		_colors [3] = _color3;
		_colors [4] = _color4;
		_colors [5] = _color5;
		_colors [6] = _color6;
		_colors [7] = _color7;
		_colors [8] = _color8;
		_colors [9] = _color9;

		_images = new Sprite[8];
		_images [0] = _foxtrot;
		_images [1] = _alfa;
		_images [2] = _shield;
		_images [3] = _aguila;
		_images [4] = _martillo;
		_images [5] = _zerozulu;
		_images [6] = _deltagolf;
		_images [7] = _hoplita;

		_Rangos = new Sprite[10];
		_Rangos [0] = _Rct;
		_Rangos [1] = _Sdo;
		_Rangos [2] = _Sdo1;
		_Rangos [3] = _Cbo;
		_Rangos [4] = _Cbo1;
		_Rangos [5] = _Sgt;
		_Rangos [6] = _Sgt1;
		_Rangos [7] = _Alfz;
		_Rangos [8] = _Tte;
		_Rangos [9] = _Cpt;

		foreach (var item in child.Children) {
			Debug.Log (item.Key);
		}
		_name.text = child.Child ("nombre").Value.ToString ();
		_posicion.text = child.Child ("Batallon").Value.ToString ();
		_autorize.text = child.Child ("autorizaciontipo").Value.ToString ();
		nombre = child.Child ("nombre").Value.ToString ();
		autorize = child.Child ("autorizaciontipo").Value.ToString ();
		posicion = child.Child ("Batallon").Value.ToString ();
		userid=child.Child ("userid").Value.ToString ();
		Faltas = child.Child ("amonestaciones").Value.ToString ();
		fechaCibi = child.Child ("cibi").Value.ToString ();
		fechaInst = child.Child ("instruccion").Value.ToString ();

		rollGranadero = child.Child ("rollgranadero").Value.ToString ();
		rollApoyo = child.Child ("rollapoyo").Value.ToString ();
		rollAt = child.Child ("rollat").Value.ToString ();
		rollMedico = child.Child ("rollmedico").Value.ToString ();
		rollTesc = child.Child ("rolltiradoresc").Value.ToString ();
		rollTdes = child.Child ("rolltiradordes").Value.ToString ();
		rollTelite = child.Child ("rollfrancotirador").Value.ToString ();
		rollObservador = child.Child ("rollobservador").Value.ToString ();

		Amo1 = child.Child ("Amonestar/Amon1").Value.ToString ();
		Amo2 = child.Child ("Amonestar/Amon2").Value.ToString ();
		Amo3 = child.Child ("Amonestar/Amon3").Value.ToString ();
		Amo4 = child.Child ("Amonestar/Amon4").Value.ToString ();
		Amo5 = child.Child ("Amonestar/Amon5").Value.ToString ();
		Amo6 = child.Child ("Amonestar/Amon6").Value.ToString ();
		Amo7 = child.Child ("Amonestar/Amon7").Value.ToString ();
		Amo8 = child.Child ("Amonestar/Amon8").Value.ToString ();
		Desc1 = child.Child ("Amonestar/Desc1").Value.ToString ();
		Desc2 = child.Child ("Amonestar/Desc2").Value.ToString ();
		Desc3 = child.Child ("Amonestar/Desc3").Value.ToString ();
		Desc4 = child.Child ("Amonestar/Desc4").Value.ToString ();
		Desc5 = child.Child ("Amonestar/Desc5").Value.ToString ();
		Desc6 = child.Child ("Amonestar/Desc6").Value.ToString ();
		Desc7 = child.Child ("Amonestar/Desc7").Value.ToString ();
		Desc8 = child.Child ("Amonestar/Desc8").Value.ToString ();

		Ina1 = child.Child ("Inasistencias/Ina1").Value.ToString ();
		Ina2 = child.Child ("Inasistencias/Ina2").Value.ToString ();
		Ina3 = child.Child ("Inasistencias/Ina3").Value.ToString ();
		Ina4 = child.Child ("Inasistencias/Ina4").Value.ToString ();
		Ina5 = child.Child ("Inasistencias/Ina5").Value.ToString ();
		Ina6 = child.Child ("Inasistencias/Ina6").Value.ToString ();
		Ina7 = child.Child ("Inasistencias/Ina7").Value.ToString ();
		Ina8 = child.Child ("Inasistencias/Ina8").Value.ToString ();
		Ina9 = child.Child ("Inasistencias/Ina9").Value.ToString ();
		Ina10 = child.Child ("Inasistencias/Ina10").Value.ToString ();
		Descr1 = child.Child ("Inasistencias/Descr1").Value.ToString ();
		Descr2 = child.Child ("Inasistencias/Descr2").Value.ToString ();
		Descr3 = child.Child ("Inasistencias/Descr3").Value.ToString ();
		Descr4 = child.Child ("Inasistencias/Descr4").Value.ToString ();
		Descr5 = child.Child ("Inasistencias/Descr5").Value.ToString ();
		Descr6 = child.Child ("Inasistencias/Descr6").Value.ToString ();
		Descr7 = child.Child ("Inasistencias/Descr7").Value.ToString ();
		Descr8 = child.Child ("Inasistencias/Descr8").Value.ToString ();
		Descr9 = child.Child ("Inasistencias/Descr9").Value.ToString ();
		Descr10 = child.Child ("Inasistencias/Descr10").Value.ToString ();

		SetImageSlot ();
		SetColorSlot ();
		data = child;

		if (NumberPlayerAutorize != "1" && NumberPlayerAutorize != "2" && NumberPlayerAutorize != "3") {
			_edit.gameObject.SetActive (false);
		}

	}

	public void SetColorSlot()
	{
		string NombreAux = "";
		for (int a = 0; a < posicion.Length; a++) {
			if (nombre [a] !='.') {
				NombreAux += nombre [a];
			} else {
				switch(NombreAux)
				{
				case "Rct":
					GetComponent<Image> ().color = _colors [0];
					rango.sprite = _Rangos [0];
					break;
				case "Sdo":
					GetComponent<Image> ().color = _colors [1];
					rango.sprite = _Rangos [1];
					break;
				case "Sdo1":
					GetComponent<Image> ().color = _colors [2];
					rango.sprite = _Rangos [2];
					break;
				case "Cbo":
					GetComponent<Image> ().color = _colors [3];
					rango.sprite = _Rangos [3];
					break;
				case "Cbo1":
					GetComponent<Image> ().color = _colors [4];
					rango.sprite = _Rangos [4];
					break;
				case "Sgt":
					GetComponent<Image> ().color = _colors [5];
					rango.sprite = _Rangos [5];
					break;
				case "Sgt1":
					GetComponent<Image> ().color = _colors [6];
					rango.sprite = _Rangos [6];
					break;
				case "Alfz":
					GetComponent<Image> ().color = _colors [7];
					rango.sprite = _Rangos [7];
					break;
				case "Tte":
					GetComponent<Image> ().color = _colors [8];
					rango.sprite = _Rangos [8];
					break;
				case "Cptn":
					GetComponent<Image> ().color = _colors [9];
					rango.sprite = _Rangos [9];
					break;
				}
				a = 20;
			}
		}
	}

	public void SetImageSlot()
	{
		switch(posicion)
		{
		case "Foxtrot":
			_Generic.sprite = _foxtrot;
			break;
		case "Alfa":
			_Generic.sprite = _alfa;
			break;
		case "Shield":
			_Generic.sprite = _shield;
			break;
		case "Aguila":
			_Generic.sprite = _aguila;
			break;
		case "Zero Zulu":
			_Generic.sprite = _zerozulu;
			break;
		case "Delta Golf":
			_Generic.sprite = _deltagolf;
			break;
		case "Martillo":
			_Generic.sprite = _martillo;
			break;
		case "Hoplita":
			_Generic.sprite = _hoplita;
			break;
		}
	}

	public void AbrirPopUp(){
		GenericPopUp puntaje=puntuador.GetComponent<GenericPopUp>();
		puntaje.SetData (_name.text, _posicion.text, filename, url, userid);
		puntuador.SetActive(true);
	}
}
