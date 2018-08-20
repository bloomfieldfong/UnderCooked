using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecogerObjeto : MonoBehaviour {

    public List<GameObject> muebles;
    public GameObject player;
    int i;
    bool pickUp;
    GameObject objectoRecogido;
    GameObject ObjetosHijos;

    public GameObject pina;
    GameObject pinasd;
 

    public GameObject manzana;
    GameObject manzanasd;

    public GameObject fresa;
    GameObject fresasd;

    void Update() {


        if (Input.GetKeyDown("space"))
        {
            i++;
            
            if (muebles[0].gameObject.tag == "CajaPina")
            {
                pinasd = Instantiate(pina, new Vector3(-4.832875f, 1f, -1.83f), Quaternion.identity);
                pinasd.transform.parent = muebles[0].transform;
                objectoRecogido = pinasd;
            }

            if (muebles[0].gameObject.tag == "CajaFresa")
            {
                fresasd = Instantiate(fresa, new Vector3(-4.912875f, 1.23f, -0.85f), Quaternion.identity);
                fresasd.transform.parent = muebles[0].transform;
                objectoRecogido = fresasd;
            }
            if (muebles[0].gameObject.tag == "CajaManza")
            {
                manzanasd = Instantiate(manzana, new Vector3(-9.47f, 1.07f, 1.5f), Quaternion.identity);
                manzanasd.transform.parent = muebles[0].transform;
                objectoRecogido = manzanasd;
            }

           
        }

        if (Input.GetKeyDown("c"))
        {
            ObjetosHijos = muebles[0].transform.GetChild(0).gameObject;
            objectoRecogido.transform.parent = player.transform;
        }

        if (Input.GetKeyDown("x"))
        {
            objectoRecogido.transform.parent = muebles[0].transform;
        }
        }

        
    


    private void OnTriggerEnter(Collider other)
    {
        muebles.Add(other.gameObject);
        if (muebles.Count > 1)
        {
            float distancia1 = Vector3.Distance(muebles[0].transform.position, transform.position);
            float distancia2 = Vector3.Distance(muebles[1].transform.position, transform.position);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        muebles.Clear();
    }
}
