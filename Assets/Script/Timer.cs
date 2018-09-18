using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour {

    public Text timerText;
    public float timeRemaining;  
	public GameObject canva;
	public GameObject jeje;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        timeRemaining -= Time.deltaTime;

        string minutos = ((int)timeRemaining / 60).ToString();
        string segundos = (timeRemaining % 60).ToString("f0");
        
        timerText.text = "Tiempo: "+ minutos + ":" + segundos;

		if (timeRemaining < 0) {
			canva.SetActive (true);
			jeje.SetActive (false);
		}
	}

   
    
}
