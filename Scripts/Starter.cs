﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Starter : MonoBehaviour {

   

	// Use this for initialization
	void Start () {
                   
    }
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown("space"))
        {
            SceneManager.LoadScene("BIG SCENE");

        }
	}

    void OnMouseDown()
    {
        //change to game screen
    }

}
