using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Continue : MonoBehaviour
{
    public GameObject howtop;
    public GameObject oraorasphere;
    public GameObject scoreboard;
    public GameObject scoreboard1;
    public GameObject buttonitself;
    public GameObject zombieShow;
    public GameObject everytimeuse;
    public GameObject winsc;
    public GameObject zombie1;
    public GameObject zombie1text;
    public GameObject zombie0text;
    public GameObject zombie2text;
    public GameObject zombie3text;
    public GameObject zombie4text;
    public GameObject zombie5text;
    public GameObject zombie2;
    public GameObject zombie3;
    public GameObject zombie4;
    public GameObject zombie5;
    public GameObject level1;
    public GameObject level0;
    public GameObject level2;
    public GameObject level3;
    public GameObject level4;
    public GameObject level5;
    public GameObject initialCam;
    public GameObject maincam;

    public static int zombieCount;
    public static bool lselected;
    
    // Start is called before the first frame update
    void Start()
    {
        zombieCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        zombieCount = Score.zombiecounthere;
        //zombieCount = SceneChange.levelno;
        
    }

    public void ContinueGame()
    {
        Debug.Log("boool"+SceneChange.levelselected);
        winsc.SetActive(false);

        if(SceneChange.levelselected == true)
        {
            if (SceneChange.levelno == -1)
            {
                initialCam.SetActive(false);
                maincam.SetActive(true);
                scoreboard.SetActive(true);
                scoreboard1.SetActive(true);

                winsc.SetActive(false);
                zombie0text.SetActive(false);
                zombie1.SetActive(false);
                zombie1text.SetActive(false);
                zombie2.SetActive(false);
                zombie2text.SetActive(false);
                zombie3.SetActive(false);
                zombie3text.SetActive(false);
                zombie4.SetActive(false);
                zombie4text.SetActive(false);
                zombie5.SetActive(false);
                zombie5text.SetActive(false);


                everytimeuse.SetActive(true);
                Debug.Log("ye hai:");
                level0.SetActive(true);
                SceneChange.returntoPos = true;
                Debug.Log("yahi hai:");
                SceneChange.howtoplayagain = true;
                howtop.SetActive(true);
                
                zombieShow.SetActive(false);
                
                buttonitself.SetActive(false);
                oraorasphere.SetActive(true);
                //Cursor.visible = false;
                //zombieCount = 1;
            }

            else if (SceneChange.levelno == 0)
            {
                //Debug.Log("zombieCount = 1");
                initialCam.SetActive(false);
                maincam.SetActive(true);

                zombie1.SetActive(false);
                zombie1text.SetActive(false);
                zombie2.SetActive(false);
                zombie2text.SetActive(false);
                zombie3.SetActive(false);
                zombie3text.SetActive(false);
                zombie4.SetActive(false);
                zombie4text.SetActive(false);
                zombie5.SetActive(false);
                zombie5text.SetActive(false);
                zombie0text.SetActive(false);


                everytimeuse.SetActive(true);
                winsc.SetActive(false);
                level1.SetActive(true);
                
                Debug.Log("hadippa got level1");
                Debug.Log("displayscore is " + Score.displayScore);
                zombieShow.SetActive(false);
                scoreboard.SetActive(true);
                scoreboard1.SetActive(true);
                SceneChange.returntoPos = true;
                buttonitself.SetActive(false);
                oraorasphere.SetActive(true);
                Score.displayScore = 10;
                
                //Cursor.visible = false;
                //zombieCount = 1;
            }

            else if (SceneChange.levelno == 1)
            {
                Debug.Log("sahi");
                initialCam.SetActive(false);
                maincam.SetActive(true);

                zombie1.SetActive(false);
                zombie1text.SetActive(false);
                zombie2.SetActive(false);
                zombie2text.SetActive(false);
                zombie3.SetActive(false);
                zombie3text.SetActive(false);
                zombie4.SetActive(false);
                zombie4text.SetActive(false);
                zombie5.SetActive(false);
                zombie5text.SetActive(false);
                zombie0text.SetActive(false);

                everytimeuse.SetActive(true);
                winsc.SetActive(false);
                level2.SetActive(true);
                SceneChange.returntoPos = true;
                zombieShow.SetActive(false);
                scoreboard.SetActive(true);
                scoreboard1.SetActive(true);
                buttonitself.SetActive(false);

                //Cursor.visible = false;
                oraorasphere.SetActive(true);
                //zombieCount = 2;

            }

            else if (SceneChange.levelno == 2)
            {
                initialCam.SetActive(false);
                maincam.SetActive(true);

                zombie1.SetActive(false);
                zombie1text.SetActive(false);
                zombie2.SetActive(false);
                zombie2text.SetActive(false);
                zombie3.SetActive(false);
                zombie3text.SetActive(false);
                zombie4.SetActive(false);
                zombie4text.SetActive(false);
                zombie5.SetActive(false);
                zombie5text.SetActive(false);
                zombie0text.SetActive(false);

                everytimeuse.SetActive(true);
                winsc.SetActive(false);
                level3.SetActive(true);
                SceneChange.returntoPos = true;
                zombieShow.SetActive(false);
                scoreboard.SetActive(true);
                scoreboard1.SetActive(true);
                buttonitself.SetActive(false);

                //Cursor.visible = false;
                oraorasphere.SetActive(true);
            }

            else if (SceneChange.levelno == 3)
            {
                //Debug.Log("zombieCount = 1");
                initialCam.SetActive(false);
                maincam.SetActive(true);

                zombie1.SetActive(false);
                zombie1text.SetActive(false);
                zombie2.SetActive(false);
                zombie2text.SetActive(false);
                zombie3.SetActive(false);
                zombie3text.SetActive(false);
                zombie4.SetActive(false);
                zombie4text.SetActive(false);
                zombie5.SetActive(false);
                zombie5text.SetActive(false);
                zombie0text.SetActive(false);


                everytimeuse.SetActive(true);
                winsc.SetActive(false);
                level4.SetActive(true);
                SceneChange.returntoPos = true;
                zombieShow.SetActive(false);
                scoreboard.SetActive(true);
                scoreboard1.SetActive(true);
                buttonitself.SetActive(false);
                oraorasphere.SetActive(true);

                //Cursor.visible = false;
                //zombieCount = 1;
            }

            else if (SceneChange.levelno == 4)
            {
                //Debug.Log("zombieCount = 1");
                initialCam.SetActive(false);
                maincam.SetActive(true);

                zombie1.SetActive(false);
                zombie1text.SetActive(false);
                zombie2.SetActive(false);
                zombie2text.SetActive(false);
                zombie3.SetActive(false);
                zombie3text.SetActive(false);
                zombie4.SetActive(false);
                zombie4text.SetActive(false);
                zombie5.SetActive(false);
                zombie5text.SetActive(false);
                zombie0text.SetActive(false);


                everytimeuse.SetActive(true);
                winsc.SetActive(false);
                level5.SetActive(true);
                SceneChange.returntoPos = true;
                zombieShow.SetActive(false);
                scoreboard.SetActive(true);
                scoreboard1.SetActive(true);
                buttonitself.SetActive(false);
                oraorasphere.SetActive(true);

                //Cursor.visible = false;
                //zombieCount = 1;
            }

            lselected = true;
            SceneChange.levelselected = false;
        }

        else
        {
            if (zombieCount == -1)
            {
                //Debug.Log("zombieCount = 1");
                initialCam.SetActive(false);
                maincam.SetActive(true);

                zombie1.SetActive(false);
                zombie1text.SetActive(false);
                zombie2.SetActive(false);
                zombie2text.SetActive(false);
                zombie3.SetActive(false);
                zombie3text.SetActive(false);
                zombie4.SetActive(false);
                zombie4text.SetActive(false);
                zombie5.SetActive(false);
                zombie5text.SetActive(false);
                zombie0text.SetActive(false);

                everytimeuse.SetActive(true);
                winsc.SetActive(false);
                level0.SetActive(true);
                SceneChange.returntoPos = true;
                zombieShow.SetActive(false);
                scoreboard.SetActive(true);
                scoreboard1.SetActive(true);
                buttonitself.SetActive(false);
                oraorasphere.SetActive(true);
                //Cursor.visible = false;
                //zombieCount = 1;
            }

            else if (zombieCount == 0)
            {
                //Debug.Log("zombieCount = 1");
                initialCam.SetActive(false);
                maincam.SetActive(true);

                zombie1.SetActive(false);
                zombie1text.SetActive(false);
                zombie2.SetActive(false);
                zombie2text.SetActive(false);
                zombie3.SetActive(false);
                zombie3text.SetActive(false);
                zombie4.SetActive(false);
                zombie4text.SetActive(false);
                zombie5.SetActive(false);
                zombie5text.SetActive(false);
                zombie0text.SetActive(false);

                everytimeuse.SetActive(true);
                winsc.SetActive(false);
                level1.SetActive(true);
                SceneChange.returntoPos = true;
                Debug.Log("hadippa2 got level1");
                zombieShow.SetActive(false);
                scoreboard.SetActive(true);
                scoreboard1.SetActive(true);
                buttonitself.SetActive(false);
                oraorasphere.SetActive(true);
                //Cursor.visible = false;
                //zombieCount = 1;
            }

            else if (zombieCount == 1)
            {
                initialCam.SetActive(false);
                maincam.SetActive(true);

                zombie1.SetActive(false);
                zombie1text.SetActive(false);
                zombie2.SetActive(false);
                zombie2text.SetActive(false);
                zombie3.SetActive(false);
                zombie3text.SetActive(false);
                zombie4.SetActive(false);
                zombie4text.SetActive(false);
                zombie5.SetActive(false);
                zombie5text.SetActive(false);
                zombie0text.SetActive(false);

                everytimeuse.SetActive(true);
                winsc.SetActive(false);
                level2.SetActive(true);
                SceneChange.returntoPos = true;
                zombieShow.SetActive(false);
                scoreboard.SetActive(true);
                scoreboard1.SetActive(true);
                buttonitself.SetActive(false);

                //Cursor.visible = false;
                oraorasphere.SetActive(true);
                //zombieCount = 2;
            }

            else if (zombieCount == 2)
            {
                initialCam.SetActive(false);
                maincam.SetActive(true);

                zombie1.SetActive(false);
                zombie1text.SetActive(false);
                zombie2.SetActive(false);
                zombie2text.SetActive(false);
                zombie3.SetActive(false);
                zombie3text.SetActive(false);
                zombie4.SetActive(false);
                zombie4text.SetActive(false);
                zombie5.SetActive(false);
                zombie5text.SetActive(false);
                zombie0text.SetActive(false);

                everytimeuse.SetActive(true);
                winsc.SetActive(false);
                level3.SetActive(true);
                SceneChange.returntoPos = true;
                zombieShow.SetActive(false);
                scoreboard.SetActive(true);
                scoreboard1.SetActive(true);
                buttonitself.SetActive(false);

                //Cursor.visible = false;
                oraorasphere.SetActive(true);
            }

            else if (zombieCount == 3)
            {
                initialCam.SetActive(false);
                maincam.SetActive(true);

                zombie1.SetActive(false);
                zombie1text.SetActive(false);
                zombie2.SetActive(false);
                zombie2text.SetActive(false);
                zombie3.SetActive(false);
                zombie3text.SetActive(false);
                zombie4.SetActive(false);
                zombie4text.SetActive(false);
                zombie5.SetActive(false);
                zombie5text.SetActive(false);
                zombie0text.SetActive(false);

                everytimeuse.SetActive(true);
                winsc.SetActive(false);
                level4.SetActive(true);
                SceneChange.returntoPos = true;
                zombieShow.SetActive(false);
                scoreboard.SetActive(true);
                scoreboard1.SetActive(true);
                buttonitself.SetActive(false);

                //Cursor.visible = false;
                oraorasphere.SetActive(true);
            }

            else if (zombieCount == 4)
            {
                initialCam.SetActive(false);
                maincam.SetActive(true);

                zombie1.SetActive(false);
                zombie1text.SetActive(false);
                zombie2.SetActive(false);
                zombie2text.SetActive(false);
                zombie3.SetActive(false);
                zombie3text.SetActive(false);
                zombie4.SetActive(false);
                zombie4text.SetActive(false);
                zombie5.SetActive(false);
                zombie5text.SetActive(false);
                zombie0text.SetActive(false);

                everytimeuse.SetActive(true);
                winsc.SetActive(false);
                level5.SetActive(true);
                SceneChange.returntoPos = true;
                zombieShow.SetActive(false);
                scoreboard.SetActive(true);
                scoreboard1.SetActive(true);
                buttonitself.SetActive(false);

                //Cursor.visible = false;
                oraorasphere.SetActive(true);
            }
        }
        
        
    }
}
