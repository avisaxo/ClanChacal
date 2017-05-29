using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using Firebase.Database;

public class puntajemanager : GenericPopUp {
		public GameObject button;
		public togglelist estrellas;

	void Start () {
		button.SetActive(false);
	}
	
	public void updatepuntaje () {
		if(estrellas.ready){
			button.SetActive(true);
		}
	}

	public void SendValoration(){
		DatabaseReference reference = FirebaseDatabase.DefaultInstance.GetReference ("Jugadores");
		reference=reference.Child (UserAuth.instance.user.UserId);
		reference=reference.Child ("valoraciones");
		reference=reference.Child (_userid);
		reference.Child ("nombre").SetValueAsync(_name.text);
		reference.Child ("puesto").SetValueAsync(_position.text);
		reference.Child ("estrellas").SetValueAsync(estrellas.cant);
		this.gameObject.SetActive (false);
	}
	
	public void Reset(){
				button.SetActive(false);
				estrellas.Reset();
	}
}
