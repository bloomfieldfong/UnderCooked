using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chopper : MonoBehaviour {

    public GameObject pina;
    GameObject pinasd;


    public GameObject manzana;
    GameObject manzanasd;

    public GameObject fresa;
    GameObject fresasd;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown("ctrl"))
        {
            
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
     

    }

}
