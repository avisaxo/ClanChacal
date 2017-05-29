using UnityEngine;
using System.Collections;
using Firebase;
using Firebase.Database;
using Firebase.Unity.Editor;
using System.Collections.Generic;
using UnityEngine.UI;

public class BotonDescr : MonoBehaviour {

	public GameObject EditorTest;
	public InputField _editorText;
	public Text Yo;
	public int NumberButon;

	public void PasoText()
	{
		EditorTest.GetComponent<EditorTextG> ().NumberButtonActual = NumberButon;
		_editorText.text = Yo.text;
	}
}
