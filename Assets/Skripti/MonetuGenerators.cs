using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonetuGenerators : MonoBehaviour {
	public GameObject[] monetuSagataves;
	public float laikaIntervals = 0.9f;
	float minPoz, maxPoz;
	public Transform vecaks;


	// Use this for initialization
	void Start () {
		vecaks = GetComponent<Transform>();
	}

	public void SagatavotMonetas(bool stavoklis)
	{
		if(stavoklis)
			StartCoroutine(Generet());
		else
			StopAllCoroutines();
	}

	IEnumerator Generet()
	{
		while(true)
		{
			minPoz = vecaks.position.x - 50;
			maxPoz = vecaks.position.x + 50;
			var cipars = Random.Range(minPoz, maxPoz);

			var pozicija = new Vector3(-cipars, transform.position.y);
			GameObject moneta =
				Instantiate(monetuSagataves[Random.Range(0, monetuSagataves.Length)],
					pozicija, Quaternion.identity, vecaks);
			yield return new WaitForSeconds(laikaIntervals);
		}
	}
}