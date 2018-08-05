using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour {

	public float velocidad = 1f;
    Vector3  giro;
    Rigidbody rb;

    void Start () {
        rb = GetComponent<Rigidbody>();
        giro = new Vector3(0, 0, -1);
        rotarJugador();

}
	
	// Update is called once per frame
	void Update () {

        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        giro = new Vector3(horizontal, 0, vertical);

        if (giro.magnitude > 0.1f)
        {
            Vector3 moveTo = giro * velocidad * Time.deltaTime;
            transform.position = transform.position + moveTo;
            rotarJugador();
        }

    }

    private void rotarJugador() {
        transform.forward = giro;
    }

    private void recogerObjetos() {
    }
}
