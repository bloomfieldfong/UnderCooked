using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class Timer : MonoBehaviour {

    public Text timerText;
    public float timeRemaining;  
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        timeRemaining -= Time.deltaTime;

        string minutos = ((int)timeRemaining / 60).ToString();
        string segundos = (timeRemaining % 60).ToString("f0");
        
        timerText.text = "Tiempo: "+ minutos + ":" + segundos;

     
	}

   
    
}
