using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using Firebase.Database;

public class AbrePopupEdit : MonoBehaviour {
	public GameObject editPlayerPopup;
	public GameObject amonestarPopup;
	public GameObject inasistenciasPopup;
	public void AbrirPopUp(){
		editPlayerPopup.GetComponent<editorPlayer>().NombreST = GetComponent<eterplayer> ().nombre;
		editPlayerPopup.GetComponent<editorPlayer>().PuestoST = GetComponent<eterplayer> ().posicion;
		editPlayerPopup.GetComponent<editorPlayer>().FechaCibiST = GetComponent<eterplayer> ().fechaCibi;
		editPlayerPopup.GetComponent<editorPlayer>().FechaInstST = GetComponent<eterplayer> ().fechaInst;
		editPlayerPopup.GetComponent<editorPlayer>().RollGranaderoST = GetComponent<eterplayer> ().rollGranadero;
		editPlayerPopup.GetComponent<editorPlayer>().RollATST = GetComponent<eterplayer> ().rollAt;
		editPlayerPopup.GetComponent<editorPlayer>().RollApoyoST = GetComponent<eterplayer> ().rollApoyo;
		editPlayerPopup.GetComponent<editorPlayer>().RollMedicoST = GetComponent<eterplayer> ().rollMedico;
		editPlayerPopup.GetComponent<editorPlayer>().RollTEscuadraST = GetComponent<eterplayer> ().rollTesc;
		editPlayerPopup.GetComponent<editorPlayer>().RollTDesignadoST = GetComponent<eterplayer> ().rollTdes;
		editPlayerPopup.GetComponent<editorPlayer>().RollTEliteST = GetComponent<eterplayer> ().rollTelite;
		editPlayerPopup.GetComponent<editorPlayer>().RollObservadorST = GetComponent<eterplayer> ().rollObservador;


		editPlayerPopup.GetComponent<editorPlayer>().data = GetComponent<eterplayer> ().data;
		editPlayerPopup.GetComponent<editorPlayer>().UserID = GetComponent<eterplayer> ().userid;
		editPlayerPopup.GetComponent<editorPlayer>().STFaltas = GetComponent<eterplayer> ().Faltas;
		editPlayerPopup.GetComponent<editorPlayer>().STAmonestaciones = GetComponent<eterplayer> ().Faltas;
		editPlayerPopup.GetComponent<editorPlayer>().STAutorizacion = GetComponent<eterplayer> ().NumberPlayerAutorize;
		amonestarPopup.GetComponent<amonestar>().UserID = GetComponent<eterplayer> ().userid;
		amonestarPopup.GetComponent<amonestar>().Amonest1ST = GetComponent<eterplayer> ().Amo1;
		amonestarPopup.GetComponent<amonestar>().Amonest2ST = GetComponent<eterplayer> ().Amo2;
		amonestarPopup.GetComponent<amonestar>().Amonest3ST = GetComponent<eterplayer> ().Amo3;
		amonestarPopup.GetComponent<amonestar>().Amonest4ST = GetComponent<eterplayer> ().Amo4;
		amonestarPopup.GetComponent<amonestar>().Amonest5ST = GetComponent<eterplayer> ().Amo5;
		amonestarPopup.GetComponent<amonestar>().Amonest6ST = GetComponent<eterplayer> ().Amo6;
		amonestarPopup.GetComponent<amonestar>().Amonest7ST = GetComponent<eterplayer> ().Amo7;
		amonestarPopup.GetComponent<amonestar>().Amonest8ST = GetComponent<eterplayer> ().Amo8;
		amonestarPopup.GetComponent<amonestar>().Description1.text = GetComponent<eterplayer> ().Desc1;
		amonestarPopup.GetComponent<amonestar>().Description2.text = GetComponent<eterplayer> ().Desc2;
		amonestarPopup.GetComponent<amonestar>().Description3.text = GetComponent<eterplayer> ().Desc3;
		amonestarPopup.GetComponent<amonestar>().Description4.text = GetComponent<eterplayer> ().Desc4;
		amonestarPopup.GetComponent<amonestar>().Description5.text = GetComponent<eterplayer> ().Desc5;
		amonestarPopup.GetComponent<amonestar>().Description6.text = GetComponent<eterplayer> ().Desc6;
		amonestarPopup.GetComponent<amonestar>().Description7.text = GetComponent<eterplayer> ().Desc7;
		amonestarPopup.GetComponent<amonestar>().Description8.text = GetComponent<eterplayer> ().Desc8;

		inasistenciasPopup.GetComponent<Inasistencia>().UserID = GetComponent<eterplayer> ().userid;
		inasistenciasPopup.GetComponent<Inasistencia>().Fecha1ST = GetComponent<eterplayer> ().Ina1;
		inasistenciasPopup.GetComponent<Inasistencia>().Fecha2ST = GetComponent<eterplayer> ().Ina2;
		inasistenciasPopup.GetComponent<Inasistencia>().Fecha3ST = GetComponent<eterplayer> ().Ina3;
		inasistenciasPopup.GetComponent<Inasistencia>().Fecha4ST = GetComponent<eterplayer> ().Ina4;
		inasistenciasPopup.GetComponent<Inasistencia>().Fecha5ST = GetComponent<eterplayer> ().Ina5;
		inasistenciasPopup.GetComponent<Inasistencia>().Fecha6ST = GetComponent<eterplayer> ().Ina6;
		inasistenciasPopup.GetComponent<Inasistencia>().Fecha7ST = GetComponent<eterplayer> ().Ina7;
		inasistenciasPopup.GetComponent<Inasistencia>().Fecha8ST = GetComponent<eterplayer> ().Ina8;
		inasistenciasPopup.GetComponent<Inasistencia>().Fecha9ST = GetComponent<eterplayer> ().Ina9;
		inasistenciasPopup.GetComponent<Inasistencia>().Fecha10ST = GetComponent<eterplayer> ().Ina10;
		inasistenciasPopup.GetComponent<Inasistencia>().Description1.text = GetComponent<eterplayer> ().Descr1;
		inasistenciasPopup.GetComponent<Inasistencia>().Description2.text = GetComponent<eterplayer> ().Descr2;
		inasistenciasPopup.GetComponent<Inasistencia>().Description3.text = GetComponent<eterplayer> ().Descr3;
		inasistenciasPopup.GetComponent<Inasistencia>().Description4.text = GetComponent<eterplayer> ().Descr4;
		inasistenciasPopup.GetComponent<Inasistencia>().Description5.text = GetComponent<eterplayer> ().Descr5;
		inasistenciasPopup.GetComponent<Inasistencia>().Description6.text = GetComponent<eterplayer> ().Descr6;
		inasistenciasPopup.GetComponent<Inasistencia>().Description7.text = GetComponent<eterplayer> ().Descr7;
		inasistenciasPopup.GetComponent<Inasistencia>().Description8.text = GetComponent<eterplayer> ().Descr8;
		inasistenciasPopup.GetComponent<Inasistencia>().Description9.text = GetComponent<eterplayer> ().Descr9;
		inasistenciasPopup.GetComponent<Inasistencia>().Description10.text = GetComponent<eterplayer> ().Descr10;

		editPlayerPopup.SetActive(true);
	}
}
