using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteMovement : MonoBehaviour {

	//attributes
	public Vector3 velocity;
	public Vector3 acceleration;
	public Vector3 notePos;
	public float maxSpeed;

	public float bottomConstraint = 0f;
	public float buffer = 1f;
	public Camera mainCam;

    public GameObject miss;

   

	// Use this for initialization
	void Start () {
		
		//set initial position
		notePos = transform.position;

		//set initial velocity
		velocity = Vector3.zero;

		//set the acceleration
		acceleration = new Vector3(0,-.001f,0);

		//bottom of screen
		bottomConstraint = mainCam.ScreenToWorldPoint( new Vector3(0f, 0f, 10f) ).y;
	}
	
	// Update is called once per frame
	void Update () {
		
		Fall ();
		SetTransform ();
		Miss ();
	}


	/// <summary>
	/// Sets the transform.
	/// </summary>
	void SetTransform()
	{

		transform.position = notePos;

	}

	void Fall()
	{
		velocity += acceleration;
		velocity = Vector3.ClampMagnitude (velocity, maxSpeed);
		notePos += velocity;
	}

	void Miss()
	{
		//if the note passes the screen then its a miss
		if (notePos.y < bottomConstraint - buffer) {

            //delete the note
            Vector3 wordPos = gameObject.transform.position;
            wordPos.y = bottomConstraint;
            Instantiate(miss, wordPos, Quaternion.identity);
            Destroy(gameObject);
            //Debug.Log ("missed");
            //to add:            
			//instance words at bottomConstraint
		}
	}
}
