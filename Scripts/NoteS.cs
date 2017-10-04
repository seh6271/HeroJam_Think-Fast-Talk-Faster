using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteS : MonoBehaviour
{

    //attributes
    private SpriteInfo boxInfo; //reference for box's position
    private SpriteInfo noteInfo;//reference for note's center
    private SpriteInfo goodInfo1; //reference for other box's position
    private SpriteInfo goodInfo2; //reference for other box's position
    private SpriteInfo badInfo; //reference for other box's position
    private Score gm;

    public ParticleSystem explode;
    public GameObject perfect;
    public GameObject good;
    public GameObject bad;


    // Use this for initialization
    void Start()
    {

        //set reference
        boxInfo = GameObject.Find("HitBox").GetComponent<SpriteInfo>();
        goodInfo1 = GameObject.Find("GoodBox").GetComponent<SpriteInfo>();
        goodInfo2 = GameObject.Find("GoodBox2").GetComponent<SpriteInfo>();
        badInfo = GameObject.Find("BadBox").GetComponent<SpriteInfo>();
        noteInfo = gameObject.GetComponent<SpriteInfo>();
        gm = GameObject.Find("ScoreHolder").GetComponent<Score>();



    }

    // Update is called once per frame
    void Update()
    {

        CheckCollision();
    }

    void CheckCollision()
    {
        //check for perfect
        if (boxInfo.min.y < noteInfo.center.y && boxInfo.max.y > noteInfo.center.y)
        {
            //center of note is inside the box
            CheckInput(5, perfect);
        }

        //check for good
        if ((goodInfo1.min.y < noteInfo.center.y && goodInfo1.max.y > noteInfo.center.y) || (goodInfo2.min.y < noteInfo.center.y && goodInfo2.max.y > noteInfo.center.y))
        {

            //check for good
            CheckInput(3, good);
        }

        //check for bad
        if (badInfo.min.y < noteInfo.center.y && badInfo.max.y > noteInfo.center.y)
        {
            CheckInput(1, bad);
        }

    }

    void CheckInput(int points, GameObject words)
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            //do they press d while in the box?
            //Debug.Log("d pressed");
            gm.score += points;
            // source.PlayOneShot(sfx);
            Instantiate(explode, gameObject.transform.position, Quaternion.identity);
            Instantiate(words, gameObject.transform.position, Quaternion.identity);
            Destroy(gameObject);

            //to add:
            //instance words at this location
        }
    }

}
