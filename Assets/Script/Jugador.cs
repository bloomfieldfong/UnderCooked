using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour {

	float velocidad;
    int s;

	void Start () {
		velocidad = 5;

	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.D)) {
			transform.Translate (0, 0, 2 * Time.deltaTime);
            s = 1;
		}

		if (Input.GetKey (KeyCode.A)) {
			transform.Translate (0, 0, -2 * Time.deltaTime);
            s = 7;
		}

		if (Input.GetKey (KeyCode.S)) {
			transform.Translate (2 * Time.deltaTime,0,0);
		}

		if (Input.GetKey (KeyCode.W)) {
			transform.Translate (-2 * Time.deltaTime,0,0);
		}

        flipZ(s);
	}

    private void flipZ(int s) {

        if (s <1) {
            Vector3 rotate = transform.localScale;
            rotate.z *= -1;
            transform.localScale = rotate;
        }
        

    }
}
