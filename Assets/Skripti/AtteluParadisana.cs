using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AtteluParadisana : MonoBehaviour {
	public GameObject JackSparrow;
	public GameObject BusinessMan;
	public GameObject Joe;
	public GameObject krekls;
	public GameObject Bikses;
	public GameObject kurpes;
	public GameObject cepure;
	public GameObject paKreisi;
	public GameObject paLabi;
	public GameObject kurRadit;
	public Sprite[] koRadit;
	public GameObject slaideris1;
	public GameObject slaideris2;

	public void binaAttelosana(bool vertiba)
	{
		JackSparrow.SetActive(vertiba);
		paKreisi.GetComponent<Toggle>().interactable = vertiba;
		paLabi.GetComponent<Toggle>().interactable = vertiba;
	}

	public void KreklaAttelosana(bool vertiba)
	{
		krekls.SetActive(vertiba);
	}

	public void BiksuAttelosana(bool vertiba)
	{
		Bikses.SetActive(vertiba);
	}

	public void KurpesAttelosana(bool vertiba)
	{
		kurpes.SetActive(vertiba);
	}
	public void CepureAttelosana(bool vertiba)
	{
		cepure.SetActive(vertiba);
	}
	public void PaKreisiBins()
	{
		JackSparrow.transform.localScale = new Vector2(1, 1);
	}

	public void PaLabiBins()
	{
		JackSparrow.transform.localScale = new Vector2(-1, 1);
	}

	public void izkritosais(int indekss){
		if (indekss == 0)
			kurRadit.GetComponent<Image> ().sprite = koRadit [0];

		else if(indekss == 1)
			kurRadit.GetComponent<Image> ().sprite = koRadit [1];

		else if(indekss == 2)
			kurRadit.GetComponent<Image> ().sprite = koRadit [2];
	}


	public void mainitLielumu(){
		float pasreizejaVertiba = slaideris1.GetComponent<Slider> ().value;
		kurRadit.transform.localScale = 
			new Vector2 (1f*pasreizejaVertiba, 1f*pasreizejaVertiba);
	}

	public void mainitRotaciju(){
		float pasreizejaVertiba = slaideris2.GetComponent<Slider> ().value;
		kurRadit.transform.localRotation =
			Quaternion.Euler (0, 0, pasreizejaVertiba * 360);
	}
}
