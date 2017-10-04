using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Words : MonoBehaviour {

    // Use this for initialization

    private Vector3 pos;
    private Vector3 velocity;

    private int counter;
	void Start () {
        pos = transform.position;
        velocity = new Vector3(0, .02f, 0);
	}
	
	// Update is called once per frame
	void Update () {

        pos += velocity;
        SetTransform();
        counter++;
        
		if(counter > 20)
        {
            Destroy(gameObject);
        }
	}

    void SetTransform()
    {

        transform.position = pos;

    }
}
