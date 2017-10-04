using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkSprite : MonoBehaviour {

    public Sprite neutralOpen;
    public Sprite neutralClose;
    public Sprite happyOpen;
    public Sprite happyClose;
    bool flapflap = false;
    float lastSwitch = 0;
    Sprite activeSprite;

    // Use this for initialization
    void Start () {
        activeSprite = neutralClose;

	}
	
	// Update is called once per frame
	void Update () {
        NeutralTalk();
        
	}

    void NeutralTalk()
    {
        if(Time.time - lastSwitch > .5f)
        {
            
            if(flapflap)
            {
                activeSprite = neutralOpen;
                Debug.Log("open");
                flapflap = false;
            }
            else
            {
                activeSprite = neutralClose;
                Debug.Log("close");
                flapflap = true;
            }
            gameObject.GetComponent<SpriteRenderer>().sprite = activeSprite;
            lastSwitch = Time.time;
        }
    }
}
