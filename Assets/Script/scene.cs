using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scene : MonoBehaviour {

    public int variable;
	// Use this for initialization
	void Start () {




    }

    // Update is called once per frame
    public void juejue () {
        SceneManager.LoadScene(variable);
    }
}
