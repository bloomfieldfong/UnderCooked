using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cocinar : MonoBehaviour {

	public GameObject pina;
	GameObject pinasd;

	public GameObject mesita;   

	public GameObject manzana;
	GameObject manzanasd;

	public GameObject fresa;
	GameObject fresasd;

	public GameObject OllaVacia;
	GameObject OllaVaciasd;

	public GameObject Ollamanzana;
	GameObject Ollamanzanasd;

	public GameObject Ollafresa;
	GameObject Ollafresasd;

	public GameObject Ollapina;
	GameObject Ollapinasd;

	public GameObject Frascomanzana;
	GameObject Frascomanzanasd;

	public GameObject Frascofresa;
	GameObject  Frascofresasd;

	public GameObject  Frascopina;
	GameObject Frascopinasd;

	public GameObject mesa2;

	public List<GameObject> uiManzana;
	public List<GameObject> uiFresa;
	public List<GameObject> uiPina;

	public AudioClip cortar;
	public AudioSource cortarSource;


	public GameObject listo;

	bool ready;
	bool serve;

	public GameObject adv;

	int i;

	public List<int> ordenActual;
	public List<int> arrayFresas;
	public List<int> arrayManza;
	public List<int> arrayPina;


	void Start(){
		
		arrayFresas.Add (0);
		arrayFresas.Add (0);
		arrayFresas.Add (0);
		arrayPina.Add (1);
		arrayPina.Add (1);
		arrayPina.Add (1);
		arrayManza.Add (2);
		arrayManza.Add (2);
		arrayManza.Add (2);

		ready = false;
		serve = false;

		cortarSource.clip = cortar;
	}
	void Update () {


		if (mesita.transform.childCount > 1 && mesita.transform.GetChild(1).gameObject.tag == "fresaCortada")
		{
			StartCoroutine(cocinarFresa());
			i++;
		}

		if (mesita.transform.childCount > 1 && mesita.transform.GetChild(1).gameObject.tag == "pinaCortada")
		{
			StartCoroutine(cocinarPina());
			i++;
		}

		if (mesita.transform.childCount > 1 && mesita.transform.GetChild(1).gameObject.tag == "manzanaCortada")
		{
			StartCoroutine(cocinarManza());
			i++;
		}

		if (ready == true) {
			StartCoroutine (Ready ());
			StartCoroutine (Advertencia ());
		}


		//SERVIR


		if (serve == true && ordenActual[0] == 2 && mesita.transform.GetChild(1).tag == "frasco") {


			Destroy(mesita.transform.GetChild(1).gameObject);
			Destroy (mesita.transform.GetChild (0).gameObject);
			serve = false;
			ready = false;

			Frascomanzanasd = Instantiate(Frascomanzana, new Vector3(2f, 0.91f, 2f), Quaternion.identity);
			Frascomanzanasd.transform.parent = mesa2.transform;

			OllaVaciasd= Instantiate(OllaVacia, new Vector3(1.2f, 1.21f, 2f), Quaternion.Euler(-90,0,0));
			OllaVaciasd.transform.parent = mesita.transform;


		}

		if (serve == true && ordenActual[0] == 1 && mesita.transform.GetChild(1).tag == "frasco") {
			
			Destroy(mesita.transform.GetChild(1).gameObject);
			Destroy(mesita.transform.GetChild(0).gameObject);

			serve = false;
			ready = false;

			Frascopinasd= Instantiate(Frascopina, new Vector3(2f, 0.91f, 2f), Quaternion.identity);
			Frascopinasd.transform.parent = mesa2.transform;

			OllaVaciasd= Instantiate(OllaVacia, new Vector3(1.2f,1.21f, 2f),Quaternion.Euler(-90,0,0));
			OllaVaciasd.transform.parent = mesita.transform;


		}

		if (serve == true && ordenActual[0] == 0 && mesita.transform.GetChild(1).tag == "frasco") {
			
			Destroy(mesita.transform.GetChild(1).gameObject);
			Destroy(mesita.transform.GetChild(0).gameObject);
			serve = false;
			ready = false;

			Frascofresasd= Instantiate(Frascofresa, new Vector3(2f, 0.91f, 2f), Quaternion.identity);
			Frascofresasd.transform.parent = mesa2.transform;

			OllaVaciasd= Instantiate(OllaVacia, new Vector3(1.2f, 1.21f, 2f), Quaternion.Euler(-90,0,0));
			OllaVaciasd.transform.parent = mesita.transform;


		}

	}

	IEnumerator cocinarPina()
	{

		Destroy(mesita.transform.GetChild(1).gameObject);
		Destroy(mesita.transform.GetChild(0).gameObject);

		Ollapinasd= Instantiate(Ollapina, new Vector3(1.2f, 1.21f, 2f), Quaternion.Euler(-90,0,0));
		Ollapinasd.transform.parent = mesita.transform;

		ordenActual.Add (1);
			Debug.Log (ordenActual);
		uiPina [i].SetActive (true);
		yield return new WaitForSeconds (3);
		if (arrayPina[0] == ordenActual[0] && arrayPina[1] == ordenActual[1] && arrayPina[2] == ordenActual[2] ) {
			ready = true;
			serve = true;
			listo.SetActive (true);
		}

	}

	IEnumerator cocinarManza()
	{

		Destroy(mesita.transform.GetChild(1).gameObject);
		Destroy(mesita.transform.GetChild(0).gameObject);


		Ollamanzanasd= Instantiate(Ollamanzana, new Vector3(1.2f, 1.21f, 2f), Quaternion.Euler(-90,0,0));
		Ollamanzanasd.transform.parent = mesita.transform;

		ordenActual.Add (2);
		Debug.Log (ordenActual);
		uiManzana [i].SetActive (true);
		yield return new WaitForSeconds (3);
		if (arrayManza[0] == ordenActual[0] && arrayManza[1] == ordenActual[1] && arrayManza[2] == ordenActual[2] ) {
			ready = true;
			serve = true;
			listo.SetActive (true);
		}

	}

	IEnumerator cocinarFresa()
	{

		Destroy(mesita.transform.GetChild(1).gameObject);
		Destroy(mesita.transform.GetChild(0).gameObject);


		Ollafresasd= Instantiate(Ollafresa, new Vector3(1.2f, 1.21f, 2f), Quaternion.Euler(-90,0,0));
		Ollafresasd.transform.parent = mesita.transform;


		ordenActual.Add (0);
		Debug.Log (ordenActual);
		uiFresa [i].SetActive (true);
		yield return new WaitForSeconds (3);
		if (arrayFresas[0] == ordenActual[0] && arrayFresas[1] == ordenActual[1] && arrayFresas[2] == ordenActual[2] ) {
			ready = true;
			serve = true;
			listo.SetActive (true);
		}


	}

	IEnumerator Ready(){

		uiFresa [0].SetActive (false);
		uiFresa [1].SetActive (false);
		uiFresa [2].SetActive (false);

		uiManzana [0].SetActive (false);
		uiManzana[1].SetActive (false);
		uiManzana [2].SetActive (false);

		uiPina [0].SetActive (false);
		uiPina [1].SetActive (false);
		uiPina [2].SetActive (false);
		ready = false;

		yield return new WaitForSeconds (7);
		Debug.Log ("se quemaaaa");
		Destroy(mesita.transform.GetChild(0).gameObject);
		adv.SetActive(false);
		serve = false;
		ordenActual.Clear ();
		OllaVaciasd= Instantiate(OllaVacia, new Vector3(1.2f, 1.21f, 2f), Quaternion.Euler(-90,0,0));
		OllaVaciasd.transform.parent = mesita.transform;
		i = 0;
	}

	IEnumerator Advertencia(){
		yield return new WaitForSeconds (4);
		cortarSource.Play ();
		Debug.Log ("advertencia");
		ordenActual.Clear ();
		listo.SetActive (false);
		adv.SetActive(true);

	}
		
}
