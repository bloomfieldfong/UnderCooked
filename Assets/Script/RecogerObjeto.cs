using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecogerObjeto : MonoBehaviour {

    public List<GameObject> muebles;
    public GameObject player;
    int i;
    bool pickUp;
    GameObject objectoRecogido;

    public GameObject pina;
    GameObject pinasd;
 

    public GameObject manzana;
    GameObject manzanasd;

    public GameObject fresa;
    GameObject fresasd;

    public GameObject manzanaCortada;
    GameObject manzaCortadasd;

    void Update() {


        if (Input.GetKeyDown("space"))
        {
            i++;

         
            //Crea los nuevos objetos de las cajas 
            if (muebles[0].gameObject.tag == "CajaPina")
            {
                pinasd = Instantiate(pina, new Vector3(-4.832875f, 1f, -1.83f), Quaternion.identity);
                pinasd.transform.parent = player.transform;
                objectoRecogido = pinasd;
            }

            if (muebles[0].gameObject.tag == "CajaFresa")
            {
                fresasd = Instantiate(fresa, new Vector3(-4.912875f, 1.23f, -0.85f), Quaternion.identity);
                fresasd.transform.parent = player.transform;
                objectoRecogido = fresasd;
            }
            if (muebles[0].gameObject.tag == "CajaManza")
            {
                manzanasd = Instantiate(manzana, new Vector3(-9.47f, 1.07f, 1.5f), Quaternion.identity);
                manzanasd.transform.parent = player.transform;
                objectoRecogido = manzanasd;
            }

            if (i%2 == 0)
            {
                objectoRecogido.transform.parent = muebles[0].transform;
                pickUp = false;
            }
        }

        if (muebles[0].gameObject.tag == "picar")
        {
            manzaCortadasd = Instantiate(manzanaCortada, new Vector3(-9.47f, 1.07f, 1.5f), Quaternion.identity);
            manzaCortadasd.transform.parent = player.transform;
            objectoRecogido = manzaCortadasd;
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
