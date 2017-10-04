using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class textimporter : MonoBehaviour
{
    public enum score { A,B,C,D,F};
    int numScore;
    score scene1;
    score scene2;
    score scene3;
    public TextAsset textfile;
    public string[] textLines;
    public string[] yokoLines;
    public string[] prestonLines;
    string theLine;
    int spacepress;

    bool choice1;
    bool choice2;
    bool good;
    bool bad;
    bool great;

    public int scene;

    public int currentYokoLine;
    public int currentPrestonLine;

    public Text theText;

    public int victoryPoints = 0;

    public Score scoreRef;
    

    // Use this for initialization
    void Start()
    {
        theLine = "(Press Space to read the next bit of dialogue)";
        theText.text = theLine;
        currentYokoLine = -1;
        currentPrestonLine = -1;
        spacepress = 0;        
        choice1 = false;
        
        
        scoreRef = GameObject.Find("ScoreHolder").GetComponent<Score>();
        if(scoreRef.score > 300)
        {
            scene1 = score.A;
        }
        if(scoreRef.score <= 300 && scoreRef.score> 250)
        {
            scene1 = score.B;
        }
        if (scoreRef.score <= 250 && scoreRef.score > 200)
        {
            scene1 = score.C;
        }
        if (scoreRef.score <= 200 && scoreRef.score > 150)
        {
            scene1 = score.D;
        }
        if (scoreRef.score <= 150 )
        {
            scene1 = score.F;
        }

        //DontDestroyOnLoad(transform.gameObject);

        if (textfile != null)
        {
            textLines = (textfile.text.Split('\n'));
            Debug.Log("HELP");
        }

        yokoLines = new string[] { textLines[1], textLines[3], textLines[4], textLines[5], textLines[6], textLines[7], textLines[8],
            textLines[9], textLines[11], textLines[13], textLines[15], textLines[17], textLines[19], textLines[20], textLines[21],
            textLines[22], textLines[23], textLines[24], textLines[26], textLines[28], textLines[30], textLines[33],
            textLines[34], textLines[36], textLines[38], textLines[40], textLines[43], textLines[45], textLines[47]};
        prestonLines = new string[] { textLines[0], textLines[2], textLines[10], textLines[12], textLines[14], textLines[16], textLines[18], textLines[25],
            textLines[27], textLines[29], textLines[31], textLines[32], textLines[35], textLines[37], textLines[39], textLines[41],
            textLines[42], textLines[44], textLines[46], textLines[48] };


    }

    // Update is called once per frame
    void Update()
    {
        if (choice1)
        {
            if(scene1 == score.F)
            {
                if (Input.GetKeyDown(KeyCode.J) || Input.GetKeyDown(KeyCode.K))
                {
                    Debug.Log("PRESS");
                    victoryPoints -= 1;
                    spacepress++;
                    choice1 = false;
                    theText.text = ChangeText();
                }
            }
            else if(scene1 == score.D)
            {
                if (Input.GetKeyDown(KeyCode.J) || Input.GetKeyDown(KeyCode.K))
                {
                    Debug.Log("PRESS");
                    victoryPoints -= 1;
                    spacepress++;
                    choice1 = false;
                    bad = true;
                    theText.text = ChangeText();
                    
                }
                if (Input.GetKeyDown(KeyCode.L))
                {
                    victoryPoints += 1;
                    spacepress++;
                    choice1 = false;
                    good = true;
                    theText.text = ChangeText();
                    
                }

            }
            else if(scene1 == score.C)
            {
                if (Input.GetKeyDown(KeyCode.J) || Input.GetKeyDown(KeyCode.K))
                {
                    Debug.Log("PRESS");
                    victoryPoints -= 1;
                    spacepress++;
                    choice1 = false;
                    bad = true;
                    theText.text = ChangeText();

                }
                if (Input.GetKeyDown(KeyCode.L) || Input.GetKeyDown(KeyCode.Semicolon))
                {
                    victoryPoints += 1;
                    spacepress++;
                    choice1 = false;
                    good = true;
                    theText.text = ChangeText();

                }
            }
            else if (scene1 == score.B)
            {
                if (Input.GetKeyDown(KeyCode.K))
                {
                    
                    victoryPoints -= 1;
                    spacepress++;
                    choice1 = false;
                    bad = true;
                    theText.text = ChangeText();

                }
                if (Input.GetKeyDown(KeyCode.L) || Input.GetKeyDown(KeyCode.Semicolon) || Input.GetKeyDown(KeyCode.J))
                {
                    victoryPoints += 1;
                    spacepress++;
                    choice1 = false;
                    good = true;
                    theText.text = ChangeText();

                }
            }
            else
            {
                if (Input.GetKeyDown(KeyCode.L) || Input.GetKeyDown(KeyCode.Semicolon) || Input.GetKeyDown(KeyCode.J))
                {
                    victoryPoints += 1;
                    spacepress++;
                    choice1 = false;
                    good = true;
                    theText.text = ChangeText();

                }
                if (Input.GetKeyDown(KeyCode.K))
                {
                    victoryPoints += 2;
                    spacepress++;
                    choice1 = false;
                    great = true;
                    theText.text = ChangeText();

                }
            }


        }
        //here comes trouble
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            theText.text = ChangeText();
            
        }
    }

    string ChangeText()
    {
        if (scoreRef.scene == 1)
        {
            switch (spacepress)
            {
                case 0:
                    theLine = textLines[50];
                    spacepress++;
                    break;
                case 1:
                    theLine = prestonLines[0];
                    spacepress++;
                    break;
                case 2:
                    theLine = yokoLines[0];
                    spacepress++;
                    break;
                case 3:
                    theLine = prestonLines[1];
                    spacepress++;
                    break;
                case 4:
                    theLine = yokoLines[1];
                    scene++;
                    spacepress = 0;
                    Debug.Log("end of scene 1");

                     //to game
                     SceneManager.LoadScene("Rhythm");
                    break;
            }

        }
        else if (scoreRef.scene == 2)
        {
            switch (spacepress)
            {
                case 0:
                    if (scene1 == score.F)
                    {
                        theLine = yokoLines[2] + " (press J to choose) \n" + yokoLines[3] + "(press K to choose)";
                        choice1 = true;
                        bad = true;
                    }
                    else if (scene1 == score.D)
                    {
                        theLine = yokoLines[2] + " (press J to choose) \n" + yokoLines[3] + "(press K to choose)\n" + yokoLines[4] + " (press L to choose)";
                        choice1 = true;
                    }
                    else if (scene1 == score.C)
                    {
                        theLine = yokoLines[2] + " (press J to choose) \n" + yokoLines[3] + "(press K to choose)\n" + yokoLines[4] + " (press L to choose)\n" + yokoLines[5] + " (press ; to choose)";
                        choice1 = true;
                    }
                    else if (scene1 == score.B)
                    {
                        theLine = yokoLines[6] + " (press J to choose) \n" + yokoLines[3] + "(press K to choose)\n" + yokoLines[4] + " (press L to choose)\n" + yokoLines[5] + " (press ; to choose)";
                        choice1 = true;
                    }
                    else
                    {
                        theLine = yokoLines[6] + " (press J to choose) \n" + yokoLines[7] + "(press K to choose)\n" + yokoLines[4] + " (press L to choose)\n" + yokoLines[5] + " (press ; to choose)";
                        choice1 = true;

                    }


                    break;
                case 1:
                    if (bad)
                    {
                        theLine = prestonLines[2];
                    }
                    if (good)
                    {
                        theLine = prestonLines[4];
                    }
                    if (great)
                    {
                        theLine = prestonLines[5];
                    }

                    spacepress++;
                    break;
                case 2:
                    if (bad)
                    {
                        theLine = yokoLines[8];
                    }
                    if (good)
                    {
                        theLine = yokoLines[10];
                        spacepress = 5;
                    }
                    if (great)
                    {
                        theLine = yokoLines[12];
                        spacepress = 5;
                    }
                    spacepress++;
                    break;
                case 3:
                    if (bad)
                    {
                        theLine = prestonLines[3];
                    }

                    spacepress++;
                    break;
                case 4:
                    if (bad)
                    {
                        theLine = yokoLines[9];
                        spacepress = 5;
                    }

                    spacepress++;
                    break;
                case 5:
                    if (bad)
                    {
                        theLine = prestonLines[4];
                    }


                    spacepress++;
                    break;
                case 6:
                    theLine = prestonLines[6];
                    good = false;
                    bad = false;
                    great = false;

                    scene++;
                    spacepress = 0;
                    Debug.Log("end of scene 1");
                    break;

            }


        }
        else if (scene == 3)
        {
            switch (spacepress)
            {
                case 0:
                    if (scene2 == score.F)
                    {
                        theLine = yokoLines[12] + " (press J to choose) \n" + yokoLines[13] + "(press K to choose)";
                        choice1 = true;
                        bad = true;
                    }
                    else if (scene2 == score.D)
                    {
                        theLine = yokoLines[12] + " (press J to choose) \n" + yokoLines[13] + "(press K to choose)\n" + yokoLines[14] + " (press L to choose)";
                        choice1 = true;
                    }
                    else if (scene2 == score.C)
                    {
                        theLine = yokoLines[12] + " (press J to choose) \n" + yokoLines[13] + "(press K to choose)\n" + yokoLines[14] + " (press L to choose)\n" + yokoLines[15] + " (press ; to choose)";
                        choice1 = true;
                    }
                    else if (scene2 == score.B)
                    {
                        theLine = yokoLines[16] + " (press J to choose) \n" + yokoLines[13] + "(press K to choose)\n" + yokoLines[14] + " (press L to choose)\n" + yokoLines[15] + " (press ; to choose)";
                        choice1 = true;
                    }
                    else
                    {
                        theLine = yokoLines[16] + " (press J to choose) \n" + yokoLines[17] + "(press K to choose)\n" + yokoLines[14] + " (press L to choose)\n" + yokoLines[15] + " (press ; to choose)";
                        choice1 = true;

                    }


                    break;
                case 1:
                    if (bad)
                    {
                        theLine = prestonLines[7];
                    }
                    if (good)
                    {
                        theLine = prestonLines[9];
                    }
                    if (great)
                    {
                        theLine = prestonLines[11];
                    }

                    spacepress++;
                    break;
                case 2:
                    if (bad)
                    {
                        theLine = yokoLines[18];
                    }
                    if (good)
                    {
                        theLine = yokoLines[20];
                        
                    }
                    if (great)
                    {
                        theLine = yokoLines[22];
                       
                    }
                    spacepress++;
                    break;
                case 3:
                    if (bad)
                    {
                        theLine = prestonLines[8];
                    }
                    if (good)
                    {
                        theLine = prestonLines[10];

                    }
                    if (great)
                    {
                        theLine = prestonLines[12];
                    }
                    spacepress++;
                    break;
                case 4:
                    if (bad)
                    {
                        theLine = yokoLines[19];
                        
                    }
                    if (good)
                    {
                        theLine = yokoLines[21];

                    }
                    if (great)
                    {
                        theLine = yokoLines[23];

                    }

                    spacepress++;
                    break;
                case 5:
                    if (bad)
                    {
                        theLine = prestonLines[4];
                    }
                    if (great)
                    {
                        theLine = prestonLines[13];
                    }

                    spacepress++;
                    break;
                case 6:
                    theLine = prestonLines[6];
                    good = false;
                    bad = false;
                    great = false;

                    scene++;
                    spacepress = 0;
                    Debug.Log("end of scene 1");
                    break;

            }
            
        }
            return theLine;
    }
}
