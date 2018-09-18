using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UI_move : MonoBehaviour {

	public GameObject panelFresa;
	public GameObject panelManza;
	public GameObject panelPina; 

	public int numero1;
	public int numero2;

	public Text texto;

	public GameObject mesita;

	public AudioClip yei;
	public AudioSource yeiSource;


	public AudioClip nei;
	public AudioSource neiSource;

	public Text textoBuenas;
	public Text textoMalas;
	public Text textTotal;

	public GameObject estrella1;
	public GameObject estrella2;
	public GameObject estrella3;


	int score;
	int totalBuenas;
	int totalMalas;
	int rnd;

	// Use this for initialization
	void Start () {
		rnd = Random.Range(numero1,numero2);	
		Debug.Log (rnd);
		yeiSource.clip = yei;
		neiSource.clip = nei;
		score = 0;
	}
	
	// Update is called once per frame
	void Update () {

		textoBuenas.text = totalBuenas.ToString ();
		textoMalas.text = totalMalas.ToString ();
		textTotal.text = (score).ToString();

		if (score > 350) {
			estrella1.SetActive (true);
			estrella2.SetActive (true);
			estrella3.SetActive (true);
		}

		if (score > 200) {
			estrella1.SetActive (true);
			estrella2.SetActive (true);

		}

		if (score > 100) {
			estrella1.SetActive (true);
		}

		texto.text = (score).ToString();

		if (rnd == 1) {
			panelFresa.SetActive (true);
		}

		if (rnd == 2) {
			panelPina.SetActive (true);
		}

		if (rnd == 3) {
			panelManza.SetActive (true);
		}


		if (mesita.transform.GetChild (2).tag == "FPina" && rnd == 2) {
			yeiSource.Play ();
			Destroy (mesita.transform.GetChild(2).gameObject);
			rnd = Random.Range(numero1,numero2);	
			Debug.Log (rnd);
			score += 20;
			totalBuenas++;
			panelPina.SetActive (false);
		}

		if (mesita.transform.GetChild (2).tag == "FFresa" && rnd == 1) {
			yeiSource.Play ();
			Destroy (mesita.transform.GetChild(2).gameObject);
			rnd = Random.Range(numero1,numero2);	
			Debug.Log (rnd);
			score += 20;
			totalBuenas++;
			panelFresa.SetActive (false);
		}

		if (mesita.transform.GetChild (2).tag == "FManza"&& rnd == 3) {
			yeiSource.Play ();
			Debug.Log ("pina :v");
			Destroy (mesita.transform.GetChild(2).gameObject);
			rnd = Random.Range(1,4);	
			Debug.Log (rnd);
			score += 20;
			totalBuenas++;
		}


		if (mesita.transform.GetChild (2).tag != "FPina" && rnd == 2) {
			neiSource.Play ();
			Destroy (mesita.transform.GetChild(2).gameObject);
			rnd = Random.Range(numero1,numero2);	
			Debug.Log (rnd);
			score -= 10;
			totalMalas++;
		}

		if (mesita.transform.GetChild (2).tag != "FFresa" && rnd == 1) {
			neiSource.Play ();
			Destroy (mesita.transform.GetChild(2).gameObject);
			rnd = Random.Range(numero1,numero2);		
			Debug.Log (rnd);
			score -= 10;
			totalMalas++;
		}

		if (mesita.transform.GetChild (2).tag != "FManza"&& rnd == 3) {
			neiSource.Play ();
			Destroy (mesita.transform.GetChild(2).gameObject);
			rnd = Random.Range(numero1,numero2);		
			Debug.Log (rnd);
			score -= 10;
			totalMalas++;
			panelManza.SetActive (false);
		}


			
	
	}

		
}
