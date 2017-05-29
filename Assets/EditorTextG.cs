using UnityEngine;
using System.Collections;
using Firebase;
using Firebase.Database;
using Firebase.Unity.Editor;
using System.Collections.Generic;
using UnityEngine.UI;

public class EditorTextG : MonoBehaviour {

	public InputField NewText;
	public GameObject Amonestaciones;
	public Text ButtonDesc;
	public List<Text> ButonList;
	public int NumberButtonActual;
	
	public void Limpia()
	{
		NewText.text = "";
	}
	public void Graba()
	{
		ButonList[NumberButtonActual].text = NewText.text;
		NewText.text = "";
	}
}
