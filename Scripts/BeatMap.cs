using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BeatMap : MonoBehaviour
{

    //attributes
    //all notes for spawning
    public GameObject noteS;
    public GameObject noteD;
    public GameObject noteF;
    public GameObject noteJ;
    public GameObject noteK;
    public GameObject noteL;

    public AudioSource part1;

    public float travelTime = 2.9f;
    public float nextSpawn;

    public Score script;


    //hell bools
    //im so sorry if you read this judges
    bool note1 = true;
    bool note2 = true;
    bool note3 = true;
    bool note4 = true;
    bool note5 = true;
    bool note6 = true;
    bool note7 = true;
    bool note8 = true;
    bool note9 = true;
    bool note10 = true;
    bool note11 = true;
    bool note12 = true;
    bool note13 = true;
    bool note14 = true;
    bool note15 = true;
    bool note16 = true;
    bool note17 = true;
    bool note18 = true;
    bool note19 = true;
    bool note20 = true;
    bool note21 = true;
    bool note22 = true;
    bool note23 = true;
    bool note24 = true;
    bool note25 = true;
    bool note26 = true;
    bool note27 = true;
    bool note28 = true;
    bool note29 = true;
    bool note30 = true;
    bool note31 = true;
    bool note32 = true;
    bool note33 = true;
    bool note34 = true;
    bool note35 = true;
    bool note36 = true;
    bool note37 = true;
    bool note38 = true;
    bool note39 = true;
    bool note40 = true;
    bool note41 = true;
    bool note42 = true;
    bool note43 = true;
    bool note44 = true;
    bool note45 = true;
    bool note46 = true;
    bool note47 = true;
    bool note48 = true;
    bool note49 = true;
    bool note50 = true;
    bool note51 = true;
    bool note52 = true;
    bool note53 = true;
    bool note54 = true;
    bool note55 = true;
    bool note56 = true;
    bool note57 = true;
    bool note58 = true;
    bool note59 = true;
    bool note60 = true;
    bool note61 = true;
    bool note62 = true;
    bool note63 = true;
    bool note64 = true;
    bool note65 = true;
    bool note66 = true;
    bool note67 = true;
    bool note68 = true;
    bool note69 = true;
    bool note70 = true;
    bool note71 = true;
    bool note72 = true;
    bool note73 = true;
    bool note74 = true;
    bool note75 = true;
    bool note76 = true;
    bool note77 = true;
    bool note78 = true;
    bool note79 = true;
    bool note80 = true;

    bool end;

    public float myTime;
    public float timer;


    // Use this for initialization
    void Start()
    {
        NoteFSpawn();
        nextSpawn = .46875f;
        end = false; myTime = 0;
        timer = 0;

        script = GameObject.Find("ScoreHolder").GetComponent<Score>();
    }

    // Update is called once per frame
    void Update()
    {

        //start the song
        if (myTime < 2.5 && myTime > 2.3)
        {
            part1.Play();
        }

        myTime += Time.deltaTime;

        //call the beatmap        
        BeatMapper();

        if(end)
        {
            timer++;
            if(timer == 400)
            {
                script.scene = 2;
                SceneManager.LoadScene("BIG SCENE");
            }
        }
        
    }

    //timing the spawns
    void BeatMapper()
    {
        //for finding time differences
        if (Input.GetKeyDown(KeyCode.M))
        {
            Debug.Log(myTime);
        }


        //opening beats
        if (myTime > nextSpawn && note1)
        {
            NoteDSpawn();
            nextSpawn += .46875f;
            note1 = false;
            return;
        }
        if (myTime > nextSpawn && note2)
        {
            NoteFSpawn();
            nextSpawn += .46875f;
            note2 = false;
            return;
        }
        if (myTime > nextSpawn && note3)
        {
            NoteDSpawn();
            nextSpawn += .46875f;
            note3 = false;
            return;
        }
        if (myTime > nextSpawn && note4)
        {
            NoteFSpawn();
            nextSpawn += .46875f;
            note4 = false;
            return;
        }
        if (myTime > nextSpawn && note5)
        {
            NoteDSpawn();
            nextSpawn += .46875f;
            note5 = false;
            return;
        }
        if (myTime > nextSpawn && note6)
        {
            NoteFSpawn();
            nextSpawn += .46875f;
            note6 = false;
            return;
        }
        if (myTime > nextSpawn && note7)
        {
            NoteDSpawn();
            nextSpawn += .46875f;
            note7 = false;
            return;
        }
        if (myTime > nextSpawn && note8)
        {
            NoteFSpawn();
            nextSpawn += .46875f;
            note8 = false;
            return;
        }
        if (myTime > nextSpawn && note9)
        {
            NoteDSpawn();
            nextSpawn += .46875f;
            note9 = false;
            return;
        }
        if (myTime > nextSpawn && note10)
        {
            NoteFSpawn();
            nextSpawn += .46875f;
            note10 = false;
            return;
        }
        if (myTime > nextSpawn && note11)
        {
            NoteDSpawn();
            nextSpawn += .46875f;
            note11 = false;
            return;
        }
        if (myTime > nextSpawn && note12)
        {
            NoteFSpawn();
            nextSpawn += .46875f;
            note12 = false;
            return;
        }
        if (myTime > nextSpawn && note13)
        {
            NoteDSpawn();
            nextSpawn += .46875f;
            note13 = false;
            return;
        }
        if (myTime > nextSpawn && note14)
        {
            NoteFSpawn();
            nextSpawn += .46875f;
            note14 = false;
            return;
        }
        if (myTime > nextSpawn && note15)
        {
            NoteDSpawn();
            nextSpawn += .46875f;
            note15 = false;
            return;
        }
        if (myTime > nextSpawn && note16)
        {
            NoteFSpawn();
            nextSpawn += .46875f;
            note16 = false;
            return;
        }
        if (myTime > nextSpawn && note17)
        {
            NoteDSpawn();
            nextSpawn += .46875f;
            note17 = false;
            return;
        }
        if (myTime > nextSpawn && note18)
        {
            NoteFSpawn();
            nextSpawn += .46875f;
            note18 = false;
            return;
        }
        if (myTime > nextSpawn && note19)
        {
            NoteDSpawn();
            nextSpawn += .46875f;
            note19 = false;
            return;
        }
        if (myTime > nextSpawn && note20)
        {
            NoteFSpawn();
            nextSpawn += .46875f;
            note20 = false;
            return;
        }
        if (myTime > nextSpawn && note21)
        {
            NoteDSpawn();
            nextSpawn += .46875f;
            note21 = false;
            return;
        }
        if (myTime > nextSpawn && note22)
        {
            NoteFSpawn();
            nextSpawn += .46875f;
            note22 = false;
            return;
        }
        if (myTime > nextSpawn && note23)
        {
            NoteDSpawn();
            nextSpawn += .46875f;
            note23 = false;
            return;
        }
        if (myTime > nextSpawn && note24)
        {
            NoteFSpawn();
            nextSpawn += .46875f;
            note24 = false;
            return;
        }
        if (myTime > nextSpawn && note25)
        {
            NoteDSpawn();
            nextSpawn += .46875f;
            note25 = false;
            return;
        }
        if (myTime > nextSpawn && note26)
        {
            NoteFSpawn();
            nextSpawn += .46875f;
            note26 = false;
            return;
        }
        if (myTime > nextSpawn && note27)
        {
            NoteDSpawn();
            nextSpawn += 2.31976f;
            note27 = false;
            return;
        }

        //melody notes
        //timestamp 0:13
        if (myTime > nextSpawn && note28)
        {
            NoteJSpawn();
            nextSpawn += .6461f;
            note28 = false;
            return;
        }
        if (myTime > nextSpawn && note29)
        {
            NoteKSpawn();
            nextSpawn += .23194f;
            note29 = false;
            return;
        }
        if (myTime > nextSpawn && note30)
        {
            NoteLSpawn();
            nextSpawn += .3479f;
            note30 = false;
            return;
        }
        if (myTime > nextSpawn && note31)
        {
            NoteKSpawn();
            nextSpawn += .28163f;
            note31 = false;
            return;
        }
        if (myTime > nextSpawn && note32)
        {
            NoteJSpawn();
            nextSpawn += .40386f;
            note32 = false;
            return;
        }

        //bass notes
        if (myTime > nextSpawn && note33)
        {
            NoteDSpawn();
            nextSpawn += .3479f;
            note33 = false;
            return;
        }
        if (myTime > nextSpawn && note34)
        {
            NoteFSpawn();
            nextSpawn += .41417f;
            note34 = false;
            return;
        }
        if (myTime > nextSpawn && note35)
        {
            NoteDSpawn();
            nextSpawn += .23103f;
            note35 = false;
            return;
        }
        if (myTime > nextSpawn && note36)
        {
            NoteFSpawn();
            nextSpawn += .26507f;
            note36 = false;
            return;
        }
        if (myTime > nextSpawn && note37)
        {
            NoteDSpawn();
            nextSpawn += .23201f;
            note37 = false;
            return;
        }
        if (myTime > nextSpawn && note38)
        {
            NoteSSpawn();
            nextSpawn += .1657f;
            note38 = false;
            return;
        }

        //bass round two
        //need to assign notes
        if (myTime > nextSpawn && note39)
        {
            NoteDSpawn();
            nextSpawn += .44689f;
            note39 = false;
            return;
        }
        if (myTime > nextSpawn && note40)
        {
            NoteSSpawn();
            nextSpawn += .3479f;
            note40 = false;
            return;
        }
        if (myTime > nextSpawn && note41)
        {
            NoteDSpawn();
            nextSpawn += .33134f;
            note41 = false;
            return;
        }
        if (myTime > nextSpawn && note42)
        {
            NoteSSpawn();
            nextSpawn += .21536f;
            note42 = false;
            return;
        }
        if (myTime > nextSpawn && note43)
        {
            NoteFSpawn();
            nextSpawn += .1988f;
            note43 = false;
            return;
        }
        if (myTime > nextSpawn && note44)
        {
            NoteSSpawn();
            nextSpawn += .3479f;
            note44 = false;
            return;
        }
        if (myTime > nextSpawn && note45)
        {
            NoteFSpawn();
            nextSpawn += .48059f;
            note45 = false;
            return;
        }
        if (myTime > nextSpawn && note46)
        {
            NoteSSpawn();
            nextSpawn += .24849f;
            note46 = false;
            return;
        }
        if (myTime > nextSpawn && note47)
        {
            NoteFSpawn();
            nextSpawn += .23207f;
            note47 = false;
            return;
        }
        if (myTime > nextSpawn && note48)
        {
            NoteDSpawn();
            nextSpawn += .23165f;
            note48 = false;
            return;
        }
        if (myTime > nextSpawn && note49)
        {
            NoteSSpawn();
            nextSpawn += .16577f;
            note49 = false;
            return;
        }
        if (myTime > nextSpawn && note50)
        {
            NoteDSpawn();
            nextSpawn += .16577f;
            note50 = false;
            return;
        }
        if (myTime > nextSpawn && note51)
        {
            NoteFSpawn();
            nextSpawn += .36462f;
            note51 = false;
            return;
        }
        if (myTime > nextSpawn && note52)
        {
            NoteJSpawn();
            nextSpawn += .16551f;
            note52 = false;
            return;
        }
        if (myTime > nextSpawn && note53)
        {
            NoteFSpawn();
            nextSpawn += .21573f;
            note53 = false;
            return;
        }

        //melody again
        if (myTime > nextSpawn && note54)
        {
            NoteJSpawn();
            nextSpawn += .6461f;
            note54 = false;
            return;
        }
        if (myTime > nextSpawn && note55)
        {
            NoteKSpawn();
            nextSpawn += .23194f;
            note55 = false;
            return;
        }
        if (myTime > nextSpawn && note56)
        {
            NoteLSpawn();
            nextSpawn += .3479f;
            note56 = false;
            return;
        }
        if (myTime > nextSpawn && note57)
        {
            NoteKSpawn();
            nextSpawn += .28163f;
            note57 = false;
            return;
        }
        if (myTime > nextSpawn && note58)
        {
            NoteJSpawn();
            nextSpawn += .40386f;
            note58 = false;
            return;
        }

        //bass part again
        if (myTime > nextSpawn && note59)
        {
            NoteDSpawn();
            nextSpawn += .3479f;
            note59 = false;
            return;
        }
        if (myTime > nextSpawn && note60)
        {
            NoteFSpawn();
            nextSpawn += .41417f;
            note60 = false;
            return;
        }
        if (myTime > nextSpawn && note61)
        {
            NoteDSpawn();
            nextSpawn += .23103f;
            note61 = false;
            return;
        }
        if (myTime > nextSpawn && note62)
        {
            NoteFSpawn();
            nextSpawn += .26507f;
            note62 = false;
            return;
        }
        if (myTime > nextSpawn && note63)
        {
            NoteDSpawn();
            nextSpawn += .23201f;
            note63 = false;
            return;
        }
        if (myTime > nextSpawn && note64)
        {
            NoteSSpawn();
            nextSpawn += .1657f;
            note64 = false;
            return;
        }

        //bass round two
        //need to assign notes
        if (myTime > nextSpawn && note65)
        {
            NoteDSpawn();
            nextSpawn += .44689f;
            note65 = false;
            return;
        }
        if (myTime > nextSpawn && note66)
        {
            NoteSSpawn();
            nextSpawn += .3479f;
            note66 = false;
            return;
        }
        if (myTime > nextSpawn && note67)
        {
            NoteDSpawn();
            nextSpawn += .33134f;
            note67 = false;
            return;
        }
        if (myTime > nextSpawn && note68)
        {
            NoteSSpawn();
            nextSpawn += .21536f;
            note68 = false;
            return;
        }
        if (myTime > nextSpawn && note69)
        {
            NoteFSpawn();
            nextSpawn += .1988f;
            note69 = false;
            return;
        }
        if (myTime > nextSpawn && note70)
        {
            NoteSSpawn();
            nextSpawn += .3479f;
            note70 = false;
            return;
        }
        if (myTime > nextSpawn && note71)
        {
            NoteFSpawn();
            nextSpawn += .48059f;
            note71 = false;
            return;
        }
        if (myTime > nextSpawn && note72)
        {
            NoteSSpawn();
            nextSpawn += .24849f;
            note72 = false;
            return;
        }
        if (myTime > nextSpawn && note73)
        {
            NoteFSpawn();
            nextSpawn += .23207f;
            note73 = false;
            return;
        }
        if (myTime > nextSpawn && note74)
        {
            NoteDSpawn();
            nextSpawn += .23165f;
            note74 = false;
            return;
        }
        if (myTime > nextSpawn && note75)
        {
            NoteSSpawn();
            nextSpawn += .16577f;
            note75 = false;
            return;
        }
        if (myTime > nextSpawn && note76)
        {
            NoteDSpawn();
            nextSpawn += .16577f;
            note76 = false;
            return;
        }
        if (myTime > nextSpawn && note77)
        {
            NoteFSpawn();
            nextSpawn += .36462f;
            note77 = false;
        
            //songs over
            end = true;
            return;
        }


    }


    //Instantiation Code
    void NoteSSpawn()
    {
        Instantiate(noteS, new Vector3(-6, 9, 0), Quaternion.identity);
    }

    void NoteDSpawn()
    {
        Instantiate(noteD, new Vector3(-4, 9, 0), Quaternion.identity);
    }

    void NoteFSpawn()
    {
        Instantiate(noteF, new Vector3(-2, 9, 0), Quaternion.identity);
    }

    void NoteJSpawn()
    {
        Instantiate(noteJ, new Vector3(2, 9, 0), Quaternion.identity);
    }

    void NoteKSpawn()
    {
        Instantiate(noteK, new Vector3(4, 9, 0), Quaternion.identity);
    }

    void NoteLSpawn()
    {
        Instantiate(noteL, new Vector3(6, 9, 0), Quaternion.identity);
    }
}