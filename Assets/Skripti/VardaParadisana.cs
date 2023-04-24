using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VardaParadisana : MonoBehaviour {

	private string teksts;
	private int teksts1;
	public GameObject ievadesLauks;
	public GameObject tekstaAttelosana;
	public GameObject IevadesLauks2;
	private string[] varianti = {"Sveiki ", "Labdien ", 
		"Prieks Tevi redzēt ", "Uzredzēšanos "};
	int nejausais;

	public void NolasitTekstu(){
		teksts = ievadesLauks.GetComponent<Text>().text;
		if (int.TryParse(IevadesLauks2.GetComponent<Text>().text, out teksts1)) {
			nejausais = Random.Range(0, varianti.Length);
			tekstaAttelosana.GetComponent<Text>().text = 
				varianti[nejausais] + teksts.ToUpper() + " jus esat " + teksts1 + " gadus vecs!";
		} else {
			tekstaAttelosana.GetComponent<Text>().text = "Lūdzu, ievadiet skaitli savā vecumā!";
		}
	}		
}

