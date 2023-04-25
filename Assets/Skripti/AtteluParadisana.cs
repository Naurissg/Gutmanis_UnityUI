using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AtteluParadisana : MonoBehaviour {
	public GameObject cilveks;
	public GameObject krekls;
	public GameObject Bikses;
	public GameObject kurpes;
	public GameObject Cepure;
	public GameObject Zobens;
	public GameObject paKreisi;
	public GameObject paLabi;
	public GameObject kurRadit;
	public Sprite[] koRadit;
	public GameObject slaideris1;
	public GameObject slaideris2;

	public void cilvekaAttelosana(bool vertiba)
	{
		cilveks.SetActive(vertiba);
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
		Cepure.SetActive(vertiba);
	}
	public void ZobenaAttelosana(bool vertiba)
	{
		Zobens.SetActive(vertiba);
	}
	public void PaKreisiBins()
	{
		cilveks.transform.localScale = new Vector2(1, 1);
	}

	public void PaLabiBins()
	{
		cilveks.transform.localScale = new Vector2(-1, 1);
	}

	public void izkritosais(int indekss){
		if (indekss == 0)
			kurRadit.GetComponent<Image> ().sprite = koRadit [0];

		else if(indekss == 1)
			kurRadit.GetComponent<Image> ().sprite = koRadit [1];

		else if(indekss == 2)
			kurRadit.GetComponent<Image> ().sprite = koRadit [2];
		
		else if(indekss == 3)
			kurRadit.GetComponent<Image> ().sprite = koRadit [3];
	}


	public void mainitPlatumu(){
		float pasreizejaVertiba = slaideris1.GetComponent<Slider> ().value;
		cilveks.transform.localScale = 
			new Vector3(1f*pasreizejaVertiba, slaideris2.GetComponent<Slider>().value, 0);
	}

	public void mainitGarumu(){
		float pasreizejaVertiba = slaideris2.GetComponent<Slider> ().value;
		cilveks.transform.localScale =
			new Vector3(slaideris1.GetComponent<Slider>().value, 1f*pasreizejaVertiba, 0);
	}
}
