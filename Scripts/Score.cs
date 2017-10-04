using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour {

    public int score;
    public int scene;

	// Use this for initialization
	void Start () {

        score = 0;
        scene = 1;

        //keep in GameOver screen
        DontDestroyOnLoad(transform.gameObject);

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
