using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Holder : MonoBehaviour {

    List<string> objetos;



	// Use this for initialization
	void Start () {
        objetos.Add("fresa");
        objetos.Add("pina");
        objetos.Add("manzana");
        objetos.Add("olla");
        objetos.Add("ollaRellena");
        objetos.Add("frasco");
        objetos.Add("frascoLleno");

    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "pina" || other.tag == "manza" || other.tag == "fresa") {
            
        }
    }

    }
