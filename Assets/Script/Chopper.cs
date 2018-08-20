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

    public GameObject mesita;

    // Use this for initialization
    void Start () {
        
    }   
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown("v") && mesita.transform.childCount > 0 && mesita.transform.GetChild(0).gameObject.tag == "fresa")
        {
            StartCoroutine(chopFresa());
        }

        if (Input.GetKeyDown("v") && mesita.transform.childCount > 0 && mesita.transform.GetChild(0).gameObject.tag == "manza")
        {
            StartCoroutine(chopManza());
        }

        if (Input.GetKeyDown("v") && mesita.transform.childCount > 0 && mesita.transform.GetChild(0).gameObject.tag == "pina")
        {
            StartCoroutine(chopPina());
        }


    }

    IEnumerator chopPina()
    {
        yield return new WaitForSeconds(2);
        Destroy(mesita.transform.GetChild(0).gameObject);
        pinasd = Instantiate(pina, new Vector3(-1.832875f, 1f, 2f), Quaternion.identity);
        pinasd.transform.parent = mesita.transform;
    }

    IEnumerator chopManza()
    {
        yield return new WaitForSeconds(2);
        Destroy(mesita.transform.GetChild(0).gameObject);
        manzanasd = Instantiate(manzana, new Vector3(-3.432875f, 1.2f, 4.23f), Quaternion.identity);
        manzanasd.transform.parent = mesita.transform;
    }

    IEnumerator chopFresa()
    {
        yield return new WaitForSeconds(2);
        Destroy(mesita.transform.GetChild(0).gameObject);
        fresasd = Instantiate(fresa, new Vector3(-1.832875f, 1f, 2f), Quaternion.identity);
        fresasd.transform.parent = mesita.transform;
    }



}
