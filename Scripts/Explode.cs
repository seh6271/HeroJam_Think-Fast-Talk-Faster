﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Explode : MonoBehaviour {

    
public ParticleSystem ps;

	// Use this for initialization
	void Start () {

        ps = gameObject.GetComponent<ParticleSystem>();
	}
	
	// Update is called once per frame
	void Update () {

        bool live = ps.IsAlive();
        if (!live)
        {
            Destroy(gameObject);
        }
		
	}
}
