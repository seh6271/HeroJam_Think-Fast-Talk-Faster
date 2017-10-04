using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteCollision : MonoBehaviour {

	//attributes
	private SpriteInfo boxInfo; //reference for box's position
	private SpriteInfo noteInfo;//reference for note's center
	private SpriteInfo goodInfo1; //reference for other box's position
	private SpriteInfo goodInfo2; //reference for other box's position
	private SpriteInfo badInfo; //reference for other box's position
	private GameManager gm;

	// Use this for initialization
	void Start () {

		//set reference
		boxInfo = GameObject.Find ("HitBox").GetComponent<SpriteInfo> ();
		goodInfo1 = GameObject.Find ("GoodBox").GetComponent<SpriteInfo> ();
		goodInfo2 = GameObject.Find ("GoodBox2").GetComponent<SpriteInfo> ();
		badInfo =  GameObject.Find ("BadBox").GetComponent<SpriteInfo> ();
		noteInfo = gameObject.GetComponent<SpriteInfo> ();
		gm = GameObject.Find ("SceneManager").GetComponent<GameManager> ();

	}
	
	// Update is called once per frame
	void Update () {
		
		CheckCollision ();		
	}

	void CheckCollision()
	{		
		//check for perfect
		if (boxInfo.min.y < noteInfo.center.y && boxInfo.max.y > noteInfo.center.y) {
			//center of note is inside the box
			CheckInput (5);
		}

		//check for good
		if ((goodInfo1.min.y < noteInfo.center.y && goodInfo1.max.y > noteInfo.center.y) || (goodInfo2.min.y < noteInfo.center.y && goodInfo2.max.y > noteInfo.center.y)) {

			//check for good
			CheckInput(3);
		}

		//check for bad
		if (badInfo.min.y < noteInfo.center.y && badInfo.max.y > noteInfo.center.y) {
			CheckInput (1);
		}

	}

	void CheckInput(int points)
	{
		if(Input.GetKeyDown(KeyCode.D))
			{
				//do they press d while in the box?
				//Debug.Log("d pressed");
				gm.score += points;
				Destroy(gameObject);

				//to add:
				//sound effect for hit
				//instance words at this location
			}
	}

}
