using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musicaFondo : MonoBehaviour {



	public AudioClip fondo;
	public AudioSource fondoSource;

	// Use this for initialization
	void Start () {
		fondoSource.clip = fondo;

		fondoSource.Play ();
		fondoSource.loop = true;
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
