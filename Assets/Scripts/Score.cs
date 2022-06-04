using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    public static int zombiecounthere;

    public Image level1button;
    public Image level2button;
    public Image level3button;
    public Image level4button;
    public Image level5button;
    private int z1;
    private int z2;
    private int z3;
    private int z4;
    private int z5;
    public bool winbutton;
    public GameObject level1;
    public GameObject level0;
    public GameObject level2;
    public GameObject level3;
    public GameObject level4;
    public GameObject level5;

    public GameObject thanksscreen;
    public GameObject winscreen;
    public TextMeshProUGUI wintext;
    public GameObject heart1;
    public GameObject heart2;
    public GameObject heart3;


    public GameObject Transition;
    public GameObject Helper;
    public TextMeshProUGUI scoreText;
    public GameObject scoreDisplayer;
    public GameObject scoredisplayer2;
    public GameObject orasphere;

    //private int repCount = -1;

    public static int displayScore;

    //level0
    private Zombie0 zombieScripto0;
    private Zombie0 zombieScripto1;
    private Zombie0 zombieScripto2;
    private Zombie0 zombieScripto3;
    
    //level1
    private Zombie zombieScript00;
    private Zombie zombieScript01;
    private Zombie zombieScript02;
    private Zombie zombieScript03;
    private Zombie zombieScript04;
    private Zombie zombieScript05;
    private Zombie zombieScript06;
    private Zombie zombieScript07;

    //level2
    private Zombie zombieScript10;
    private Zombie zombieScript11;
    private Zombie zombieScript12;
    private Zombie zombieScript13;
    private Zombie zombieScript14;
    private Zombie2 zombieScript15;
    private Zombie2 zombieScript16;
    private Zombie2 zombieScript17;

    //level3
    private Zombie zombieScript30;
    private Zombie zombieScript31;
    private Zombie zombieScript32;
    private Zombie zombieScript33;
    private Zombie zombieScript34;
    private Zombie childScript30;
    private Zombie childScript31;
    private Zombie childScript32;
    private Zombie childScript33;
    private Zombie2 zombieScript35;
    private Zombie2 zombieScript36;
    private Zombie2 zombieScript37;
    private Zombie3 zombieScript38;
    private Zombie3 zombieScript39;

    //level4
    private Zombie zombieScript40;
    private Zombie zombieScript41;
    private Zombie zombieScript42;
    private Zombie zombieScript43;
    private Zombie2 zombieScript44;
    private Zombie2 zombieScript45;
    private Zombie3 zombieScript46;
    private Zombie3 zombieScript47;
    private Zombie4 zombieScript48;
    private Zombie4 zombieScript49;
    private Zombie childScript40;
    private Zombie childScript41;
    private Zombie childScript42;
    private Zombie childScript43;
    private Zombie2 childScript44;
    private Zombie2 childScript45;
    private Zombie2 childScript46;
    private Zombie2 childScript47;

    //level5
    private Zombie zombieScript50;
    private Zombie zombieScript51;
    private Zombie zombieScript52;
    private Zombie zombieScript53;
    private Zombie2 zombieScript54;
    private Zombie2 zombieScript55;
    private Zombie3 zombieScript56;
    private Zombie3 zombieScript57;
    private Zombie4 zombieScript58;
    private Zombie5 zombieScript59;
    private Zombie5 zombieScript60;
    private Zombie childScript50;
    private Zombie childScript51;
    private Zombie childScript52;
    private Zombie childScript53;
    private Zombie2 childScript54;
    private Zombie2 childScript55;
    private Zombie3 childScript56;
    private Zombie3 childScript57;
    private Zombie3 childScript58;
    private Zombie3 childScript59;
    private Zombie childScript60;
    private Zombie childScript61;
    private Zombie childScript62;
    private Zombie childScript63;
    private Zombie childScript64;
    private Zombie childScript65;
    private Zombie childScript66;
    private Zombie childScript67;

    //level0
    public GameObject zombieo0;
    public GameObject zombieo1;
    public GameObject zombieo2;
    public GameObject zombieo3;

    //level1
    public GameObject zombie00;
    public GameObject zombie01;
    public GameObject zombie02;
    public GameObject zombie03;
    public GameObject zombie04;
    public GameObject zombie05;
    public GameObject zombie06;
    public GameObject zombie07;

    //level2
    public GameObject zombie10;
    public GameObject zombie11;
    public GameObject zombie12;
    public GameObject zombie13;
    public GameObject zombie14;
    public GameObject zombie15;
    public GameObject zombie16;
    public GameObject zombie17;

    //level3
    public GameObject zombie30;
    public GameObject zombie31;
    public GameObject zombie32;
    public GameObject zombie33;
    public GameObject zombie34;
    public GameObject child30;
    public GameObject child31;
    public GameObject child32;
    public GameObject child33;
    public GameObject zombie35;
    public GameObject zombie36;
    public GameObject zombie37;
    public GameObject zombie38;
    public GameObject zombie39;

    //level4
    public GameObject zombie40;
    public GameObject zombie41;
    public GameObject zombie42;
    public GameObject zombie43;
    public GameObject zombie44;
    public GameObject zombie45;
    public GameObject zombie46;
    public GameObject zombie47;
    public GameObject zombie48;
    public GameObject zombie49;
    public GameObject child40;
    public GameObject child41;
    public GameObject child42;
    public GameObject child43;
    public GameObject child44;
    public GameObject child45;
    public GameObject child46;
    public GameObject child47;

    //level5
    public GameObject zombie50;
    public GameObject zombie51;
    public GameObject zombie52;
    public GameObject zombie53;
    public GameObject zombie54;
    public GameObject zombie55;
    public GameObject zombie56;
    public GameObject zombie57;
    public GameObject zombie58;
    public GameObject zombie59;
    public GameObject zombie60;
    public GameObject child50;
    public GameObject child51;
    public GameObject child52;
    public GameObject child53;
    public GameObject child54;
    public GameObject child55;
    public GameObject child56;
    public GameObject child57;
    public GameObject child58;
    public GameObject child59;
    public GameObject child60;
    public GameObject child61;
    public GameObject child62;
    public GameObject child63;
    public GameObject child64;
    public GameObject child65;
    public GameObject child66;
    public GameObject child67;

    public bool checkzc;
    private bool tmp = false;

    void Start()
    {
        zombiecounthere = -1;

        //level0
        zombieScripto0 = zombieo0.GetComponent<Zombie0>();
        zombieScripto1 = zombieo1.GetComponent<Zombie0>();
        zombieScripto2 = zombieo2.GetComponent<Zombie0>();
        zombieScripto3 = zombieo3.GetComponent<Zombie0>();

        //level1
        zombieScript00 = zombie00.GetComponent<Zombie>();
        zombieScript01 = zombie01.GetComponent<Zombie>();
        zombieScript02 = zombie02.GetComponent<Zombie>();
        zombieScript03 = zombie03.GetComponent<Zombie>();
        zombieScript04 = zombie04.GetComponent<Zombie>();
        zombieScript05 = zombie05.GetComponent<Zombie>();
        zombieScript06 = zombie06.GetComponent<Zombie>();
        zombieScript07 = zombie07.GetComponent<Zombie>();

        //level2
        zombieScript10 = zombie10.GetComponent<Zombie>();
        zombieScript11 = zombie11.GetComponent<Zombie>();
        zombieScript12 = zombie12.GetComponent<Zombie>();
        zombieScript13 = zombie13.GetComponent<Zombie>();
        zombieScript14 = zombie14.GetComponent<Zombie>();
        zombieScript15 = zombie15.GetComponent<Zombie2>();
        zombieScript16 = zombie16.GetComponent<Zombie2>();
        zombieScript17 = zombie17.GetComponent<Zombie2>();

        //level3
        zombieScript30 = zombie30.GetComponent<Zombie>();
        zombieScript31 = zombie31.GetComponent<Zombie>();
        zombieScript32 = zombie32.GetComponent<Zombie>();
        zombieScript33 = zombie33.GetComponent<Zombie>();
        zombieScript34 = zombie34.GetComponent<Zombie>();
        childScript30 = child30.GetComponent<Zombie>();
        childScript31 = child31.GetComponent<Zombie>();
        childScript32 = child32.GetComponent<Zombie>();
        childScript33 = child33.GetComponent<Zombie>();
        zombieScript35 = zombie35.GetComponent<Zombie2>();
        zombieScript36 = zombie36.GetComponent<Zombie2>();
        zombieScript37 = zombie37.GetComponent<Zombie2>();
        zombieScript38 = zombie38.GetComponent<Zombie3>();
        zombieScript39 = zombie39.GetComponent<Zombie3>();

        //level4
        zombieScript40 = zombie40.GetComponent<Zombie>();
        zombieScript41 = zombie41.GetComponent<Zombie>();
        zombieScript42 = zombie42.GetComponent<Zombie>();
        zombieScript43 = zombie43.GetComponent<Zombie>();
        zombieScript44 = zombie44.GetComponent<Zombie2>();
        zombieScript45 = zombie45.GetComponent<Zombie2>();
        zombieScript46 = zombie46.GetComponent<Zombie3>();
        zombieScript47 = zombie47.GetComponent<Zombie3>();
        zombieScript48 = zombie48.GetComponent<Zombie4>();
        zombieScript49 = zombie49.GetComponent<Zombie4>();
        childScript40 = child40.GetComponent<Zombie>();
        childScript41 = child41.GetComponent<Zombie>();
        childScript42 = child42.GetComponent<Zombie>();
        childScript43 = child43.GetComponent<Zombie>();
        childScript44 = child44.GetComponent<Zombie2>();
        childScript45 = child45.GetComponent<Zombie2>();
        childScript46 = child46.GetComponent<Zombie2>();
        childScript47 = child47.GetComponent<Zombie2>();

        //level5
        zombieScript50 = zombie50.GetComponent<Zombie>();
        zombieScript51 = zombie51.GetComponent<Zombie>();
        zombieScript52 = zombie52.GetComponent<Zombie>();
        zombieScript53 = zombie53.GetComponent<Zombie>();
        zombieScript54 = zombie54.GetComponent<Zombie2>();
        zombieScript55 = zombie55.GetComponent<Zombie2>();
        zombieScript56 = zombie56.GetComponent<Zombie3>();
        zombieScript57 = zombie57.GetComponent<Zombie3>();
        zombieScript58 = zombie58.GetComponent<Zombie4>();
        zombieScript59 = zombie59.GetComponent<Zombie5>();
        zombieScript60 = zombie60.GetComponent<Zombie5>();
        childScript50 = child50.GetComponent<Zombie>();
        childScript51 = child51.GetComponent<Zombie>();
        childScript52 = child52.GetComponent<Zombie>();
        childScript53 = child53.GetComponent<Zombie>();
        childScript54 = child54.GetComponent<Zombie2>();
        childScript55 = child55.GetComponent<Zombie2>();
        childScript56 = child56.GetComponent<Zombie3>();
        childScript57 = child57.GetComponent<Zombie3>();
        childScript58 = child58.GetComponent<Zombie3>();
        childScript59 = child59.GetComponent<Zombie3>();
        childScript60 = child60.GetComponent<Zombie>();
        childScript61 = child61.GetComponent<Zombie>();
        childScript62 = child62.GetComponent<Zombie>();
        childScript63 = child63.GetComponent<Zombie>();
        childScript64 = child64.GetComponent<Zombie>();
        childScript65 = child65.GetComponent<Zombie>();
        childScript66 = child66.GetComponent<Zombie>();
        childScript67 = child67.GetComponent<Zombie>();



        scoreText = scoreDisplayer.GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        checkzc = SceneChange.start_before_demo;
        //zombiecounthere = SceneChange.levelno;

        if(checkzc == true && tmp == false)
        {
            //repCount = 0;
            zombiecounthere = 0;
            displayScore = 1000;
            tmp = true;
        }

        //Debug.Log(checkzc);

        //Debug.Log("levelselected = " + SceneChange.levelselected);

        if (Continue.lselected == true)
        {
            if (SceneChange.levelno == -1)
            {
                displayScore = 4 - zombieScripto0.score - zombieScripto1.score - zombieScripto2.score - zombieScripto3.score;

                if (displayScore == 0)
                {
                    SceneChange.boollevel1 = true;
                    level1button.GetComponent<Image>().color = Color.white;

                    orasphere.SetActive(false);
                    orasphere.transform.position = new Vector3(-3.62f, 0, 9.46f);
                    Cursor.visible = true;
                    scoreDisplayer.SetActive(false);
                    scoredisplayer2.SetActive(false);
                    level0.SetActive(false);

                    zombieScripto0.score = 0;
                    zombieScripto1.score = 0;
                    zombieScripto2.score = 0;
                    //repCount = 0;
                    //zombiecounthere = 0;
                    Continue.lselected = false;

                    displayScore = 1000;
                }

                scoreText.text = displayScore.ToString();
            }
            //Debug.Log(displayScore);
            else if (SceneChange.levelno == 0)
            {
                //Debug.Log("sahi");
                displayScore = 8 - zombieScript00.score - zombieScript01.score - zombieScript02.score - zombieScript03.score - zombieScript04.score -
                    zombieScript05.score - zombieScript06.score - zombieScript07.score;

                if (displayScore == 0)
                {
                    SceneChange.boollevel2 = true;

                    level2button.GetComponent<Image>().color = Color.white;

                    //Debug.Log("oooo");
                    orasphere.SetActive(false);
                    orasphere.transform.position = new Vector3(-3.62f, 0, 9.46f);
                    Cursor.visible = true;
                    scoreDisplayer.SetActive(false);
                    scoredisplayer2.SetActive(false);

                    //Helper.SetActive(false);
                    
                    level1.SetActive(false);
                    //<<-------------------changed this 20:43 14/5/22
                    winscreen.SetActive(true);
                    Debug.Log("winscreen is activated");
                    Debug.Log("displayscore is " + displayScore);
                    wintext.text = "Congratulations on clearing LEVEL 1!";
                    if (Castle.lives == 1)
                    {
                        heart1.SetActive(true);
                        heart2.SetActive(false);
                        heart3.SetActive(false);
                    }
                    else if (Castle.lives == 2)
                    {
                        heart1.SetActive(true);
                        heart2.SetActive(true);
                        heart3.SetActive(false);
                    }
                    else if (Castle.lives == 3)
                    {
                        heart1.SetActive(true);
                        heart2.SetActive(true);
                        heart3.SetActive(true);
                    }
                    TextTransfer.questionCount = 0;
                    StartCoroutine(Win1());

                    displayScore = 100;
                }

                scoreText.text = displayScore.ToString();
            }

            else if (SceneChange.levelno == 1)
            {
                displayScore = 8 - zombieScript10.score - zombieScript11.score - zombieScript12.score - zombieScript13.score -
                    zombieScript14.score - zombieScript15.score - zombieScript16.score - zombieScript17.score;

                if (displayScore == 0)
                {
                    //Continue.lselected = false;
                    SceneChange.boollevel3 = true;
                    level3button.GetComponent<Image>().color = Color.white;

                    orasphere.SetActive(false);
                    orasphere.transform.position = new Vector3(-3.62f, 0, 9.46f);
                    Cursor.visible = true;
                    scoreDisplayer.SetActive(false);
                    scoredisplayer2.SetActive(false);

                    //Helper.SetActive(false);
                    level2.SetActive(false);
                    winscreen.SetActive(true);
                    wintext.text = "Congratulations on clearing LEVEL 2!";
                    if (Castle.lives == 1)
                    {
                        heart1.SetActive(true);
                        heart2.SetActive(false);
                        heart3.SetActive(false);
                    }
                    else if (Castle.lives == 2)
                    {
                        heart1.SetActive(true);
                        heart2.SetActive(true);
                        heart3.SetActive(false);
                    }
                    else if (Castle.lives == 3)
                    {
                        heart1.SetActive(true);
                        heart2.SetActive(true);
                        heart3.SetActive(true);
                    }
                    TextTransfer.questionCount = 3;
                    StartCoroutine(Win2());

                    displayScore = 100;
                }

                scoreText.text = displayScore.ToString();
                //Debug.Log(displayScore);
            }

            else if (SceneChange.levelno == 2)
            {
                displayScore = 10 - zombieScript30.score - zombieScript31.score - zombieScript32.score - zombieScript33.score -
                    zombieScript34.score - zombieScript35.score - zombieScript36.score - zombieScript37.score - zombieScript38.score - zombieScript39.score
                    - childScript30.score - childScript31.score - childScript32.score - childScript33.score;

                /*Debug.Log("start" + zombieScript30.score);
                Debug.Log(zombieScript31.score);
                Debug.Log(zombieScript32.score);
                Debug.Log(zombieScript33.score);
                Debug.Log(zombieScript34.score);
                Debug.Log(zombieScript35.score);
                Debug.Log(zombieScript36.score);
                Debug.Log(zombieScript37.score);
                Debug.Log(zombieScript38.score);
                Debug.Log(zombieScript39.score);
                Debug.Log(childScript30.score);
                Debug.Log(childScript31.score);
                Debug.Log(childScript32.score);
                Debug.Log(childScript33.score);*/

                if (displayScore == 0)
                {
                    //Continue.lselected = false;
                    SceneChange.boollevel4 = true;
                    level4button.GetComponent<Image>().color = Color.white;

                    orasphere.SetActive(false);
                    orasphere.transform.position = new Vector3(-3.62f, 0, 9.46f);
                    Cursor.visible = true;
                    scoreDisplayer.SetActive(false);
                    scoredisplayer2.SetActive(false);

                    //Helper.SetActive(false);
                    level3.SetActive(false);
                    winscreen.SetActive(true);
                    wintext.text = "Congratulations on clearing LEVEL 3!";
                    if (Castle.lives == 1)
                    {
                        heart1.SetActive(true);
                        heart2.SetActive(false);
                        heart3.SetActive(false);
                    }
                    else if (Castle.lives == 2)
                    {
                        heart1.SetActive(true);
                        heart2.SetActive(true);
                        heart3.SetActive(false);
                    }
                    else if (Castle.lives == 3)
                    {
                        heart1.SetActive(true);
                        heart2.SetActive(true);
                        heart3.SetActive(true);
                    }
                    TextTransfer.questionCount = 6;
                    StartCoroutine(Win3());

                    displayScore = 1000;
                }

                scoreText.text = displayScore.ToString();
                //Debug.Log(displayScore);
            }

            else if (SceneChange.levelno == 3)
            {
                displayScore = 10 - zombieScript40.score - zombieScript41.score - zombieScript42.score - zombieScript43.score -
                    zombieScript44.score - zombieScript45.score - zombieScript46.score - zombieScript47.score - zombieScript48.score - zombieScript49.score
                    - childScript40.score - childScript41.score - childScript42.score - childScript43.score - childScript44.score - childScript45.score
                     - childScript46.score - childScript47.score;

                if (displayScore == 0)
                {
                    //Continue.lselected = false;
                    SceneChange.boollevel5 = true;
                    level5button.GetComponent<Image>().color = Color.white;

                    orasphere.SetActive(false);
                    orasphere.transform.position = new Vector3(-3.62f, 0, 9.46f);
                    Cursor.visible = true;
                    scoreDisplayer.SetActive(false);
                    scoredisplayer2.SetActive(false);

                    //Helper.SetActive(false);
                    level4.SetActive(false);
                    winscreen.SetActive(true);
                    wintext.text = "Congratulations on clearing LEVEL 4!";
                    if (Castle.lives == 1)
                    {
                        heart1.SetActive(true);
                        heart2.SetActive(false);
                        heart3.SetActive(false);
                    }
                    else if (Castle.lives == 2)
                    {
                        heart1.SetActive(true);
                        heart2.SetActive(true);
                        heart3.SetActive(false);
                    }
                    else if (Castle.lives == 3)
                    {
                        heart1.SetActive(true);
                        heart2.SetActive(true);
                        heart3.SetActive(true);
                    }
                    StartCoroutine(Win4());
                    TextTransfer.questionCount = 9;
                    displayScore = 1000;
                }

                scoreText.text = displayScore.ToString();
                //Debug.Log(displayScore);
            }

            else if (SceneChange.levelno == 4)
            {
                displayScore = 11 - zombieScript50.score - zombieScript51.score - zombieScript52.score - zombieScript53.score -
                    zombieScript54.score - zombieScript55.score - zombieScript56.score - zombieScript57.score - zombieScript58.score - zombieScript59.score
                     - zombieScript60.score - childScript50.score - childScript51.score - childScript52.score - childScript53.score - childScript54.score - childScript55.score
                     - childScript56.score - childScript57.score - childScript58.score - childScript59.score - childScript60.score - childScript61.score
                      - childScript62.score - childScript63.score - childScript64.score - childScript65.score - childScript66.score - childScript67.score;

                if (displayScore == 0)
                {
                    //Continue.lselected = false;
                    orasphere.SetActive(false);
                    orasphere.transform.position = new Vector3(-3.62f, 0, 9.46f);
                    Cursor.visible = true;
                    scoreDisplayer.SetActive(false);
                    scoredisplayer2.SetActive(false);

                    //Helper.SetActive(false);
                    level5.SetActive(false);
                    winscreen.SetActive(true);
                    wintext.text = "Congratulations on clearing LEVEL 5!";
                    if (Castle.lives == 1)
                    {
                        heart1.SetActive(true);
                        heart2.SetActive(false);
                        heart3.SetActive(false);
                    }
                    else if (Castle.lives == 2)
                    {
                        heart1.SetActive(true);
                        heart2.SetActive(true);
                        heart3.SetActive(false);
                    }
                    else if (Castle.lives == 3)
                    {
                        heart1.SetActive(true);
                        heart2.SetActive(true);
                        heart3.SetActive(true);
                    }
                    TextTransfer.questionCount = 12;
                    StartCoroutine(Win5());

                    displayScore = 1000;
                }

                scoreText.text = displayScore.ToString();
                //Debug.Log(displayScore);
            }
            //SceneChange.levelselected = false;
            //Continue.lselected = false;
        }
        else
        {
            if (zombiecounthere == -1)
            {
                displayScore = 4 - zombieScripto0.score - zombieScripto1.score - zombieScripto2.score - zombieScripto3.score;

                /*Debug.Log("01: "+zombieScripto0.score);
                Debug.Log("02: "+zombieScripto1.score);
                Debug.Log("end: "+zombieScripto2.score);*/

                if (displayScore == 0)
                {
                    SceneChange.boollevel1 = true;
                    level1button.GetComponent<Image>().color = Color.white;

                    orasphere.SetActive(false);
                    orasphere.transform.position = new Vector3(-3.62f, 0, 9.46f);
                    Cursor.visible = true;
                    scoreDisplayer.SetActive(false);
                    scoredisplayer2.SetActive(false);
                    level0.SetActive(false);

                    zombieScripto0.score = 0;
                    zombieScripto1.score = 0;
                    zombieScripto2.score = 0;
                    //repCount = 0;
                    //zombiecounthere = 0;
                    displayScore = 100;
                }

                scoreText.text = displayScore.ToString();
            }
            //Debug.Log(displayScore);
            else if (zombiecounthere == 0)
            {
                displayScore = 8 - zombieScript00.score - zombieScript01.score - zombieScript02.score - zombieScript03.score - zombieScript04.score -
                    zombieScript05.score - zombieScript06.score - zombieScript07.score;

                if (displayScore == 0)
                {
                    SceneChange.boollevel2 = true;
                    level2button.GetComponent<Image>().color = Color.white;

                    //Debug.Log("oooo");
                    orasphere.SetActive(false);
                    orasphere.transform.position = new Vector3(-3.62f, 0, 9.46f);
                    Cursor.visible = true;
                    scoreDisplayer.SetActive(false);
                    scoredisplayer2.SetActive(false);

                    //Helper.SetActive(false);
                    level1.SetActive(false);
                    winscreen.SetActive(true);
                    wintext.text = "Congratulations on clearing LEVEL 1!";
                    if (Castle.lives == 1)
                    {
                        heart1.SetActive(true);
                        heart2.SetActive(false);
                        heart3.SetActive(false);
                    }
                    else if (Castle.lives == 2)
                    {
                        heart1.SetActive(true);
                        heart2.SetActive(true);
                        heart3.SetActive(false);
                    }
                    else if (Castle.lives == 3)
                    {
                        heart1.SetActive(true);
                        heart2.SetActive(true);
                        heart3.SetActive(true);
                    }
                    TextTransfer.questionCount = 0;
                    StartCoroutine(Win11());
                    
                    displayScore = 100;
                }

                scoreText.text = displayScore.ToString();
            }

            else if (zombiecounthere == 1)
            {
                displayScore = 8 - zombieScript10.score - zombieScript11.score - zombieScript12.score - zombieScript13.score -
                    zombieScript14.score - zombieScript15.score - zombieScript16.score - zombieScript17.score;

                if (displayScore == 0)
                {
                    SceneChange.boollevel3 = true;
                    level3button.GetComponent<Image>().color = Color.white;

                    orasphere.SetActive(false);
                    orasphere.transform.position = new Vector3(-3.62f, 0, 9.46f);
                    Cursor.visible = true;
                    scoreDisplayer.SetActive(false);
                    scoredisplayer2.SetActive(false);

                    //Helper.SetActive(false);
                    level2.SetActive(false);
                    winscreen.SetActive(true);
                    wintext.text = "Congratulations on clearing LEVEL 2!";
                    if (Castle.lives == 1)
                    {
                        heart1.SetActive(true);
                        heart2.SetActive(false);
                        heart3.SetActive(false);
                    }
                    else if (Castle.lives == 2)
                    {
                        heart1.SetActive(true);
                        heart2.SetActive(true);
                        heart3.SetActive(false);
                    }
                    else if (Castle.lives == 3)
                    {
                        heart1.SetActive(true);
                        heart2.SetActive(true);
                        heart3.SetActive(true);
                    }
                    TextTransfer.questionCount = 3;
                    StartCoroutine(Win21());
                    displayScore = 100;
                }

                scoreText.text = displayScore.ToString();
                //Debug.Log(displayScore);
            }

            else if (zombiecounthere == 2)
            {
                displayScore = 10 - zombieScript30.score - zombieScript31.score - zombieScript32.score - zombieScript33.score -
                    zombieScript34.score - zombieScript35.score - zombieScript36.score - zombieScript37.score - zombieScript38.score - zombieScript39.score
                    - childScript30.score - childScript31.score - childScript32.score - childScript33.score;

                if (displayScore == 0)
                {
                    SceneChange.boollevel4 = true;
                    level4button.GetComponent<Image>().color = Color.white;

                    orasphere.SetActive(false);
                    orasphere.transform.position = new Vector3(-3.62f, 0, 9.46f);
                    Cursor.visible = true;
                    scoreDisplayer.SetActive(false);
                    scoredisplayer2.SetActive(false);

                    //Helper.SetActive(false);
                    level3.SetActive(false);
                    winscreen.SetActive(true);
                    wintext.text = "Congratulations on clearing LEVEL 3!";
                    if (Castle.lives == 1)
                    {
                        heart1.SetActive(true);
                        heart2.SetActive(false);
                        heart3.SetActive(false);
                    }
                    else if (Castle.lives == 2)
                    {
                        heart1.SetActive(true);
                        heart2.SetActive(true);
                        heart3.SetActive(false);
                    }
                    else if (Castle.lives == 3)
                    {
                        heart1.SetActive(true);
                        heart2.SetActive(true);
                        heart3.SetActive(true);
                    }
                    TextTransfer.questionCount = 6;
                    StartCoroutine(Win31());
                    displayScore = 1000;
                }

                scoreText.text = displayScore.ToString();
                //Debug.Log(displayScore);
            }

            else if (zombiecounthere == 3)
            {
                displayScore = 10 - zombieScript40.score - zombieScript41.score - zombieScript42.score - zombieScript43.score -
                    zombieScript44.score - zombieScript45.score - zombieScript46.score - zombieScript47.score - zombieScript48.score - zombieScript49.score
                    - childScript40.score - childScript41.score - childScript42.score - childScript43.score - childScript44.score - childScript45.score
                     - childScript46.score - childScript47.score;

                if (displayScore == 0)
                {
                    SceneChange.boollevel5 = true;
                    level5button .GetComponent<Image>().color = Color.white;

                    orasphere.SetActive(false);
                    orasphere.transform.position = new Vector3(-3.62f, 0, 9.46f);
                    Cursor.visible = true;
                    scoreDisplayer.SetActive(false);
                    scoredisplayer2.SetActive(false);

                    //Helper.SetActive(false);
                    level4.SetActive(false);
                    winscreen.SetActive(true);
                    wintext.text = "Congratulations on clearing LEVEL 4!";
                    if (Castle.lives == 1)
                    {
                        heart1.SetActive(true);
                        heart2.SetActive(false);
                        heart3.SetActive(false);
                    }
                    else if (Castle.lives == 2)
                    {
                        heart1.SetActive(true);
                        heart2.SetActive(true);
                        heart3.SetActive(false);
                    }
                    else if (Castle.lives == 3)
                    {
                        heart1.SetActive(true);
                        heart2.SetActive(true);
                        heart3.SetActive(true);
                    }
                    TextTransfer.questionCount = 9;
                    StartCoroutine(Win41());
                    displayScore = 1000;
                }

                scoreText.text = displayScore.ToString();
                //Debug.Log(displayScore);
            }
            else if (zombiecounthere == 4)
            {
                displayScore = 11 - zombieScript50.score - zombieScript51.score - zombieScript52.score - zombieScript53.score -
                    zombieScript54.score - zombieScript55.score - zombieScript56.score - zombieScript57.score - zombieScript58.score - zombieScript59.score
                     - zombieScript60.score - childScript50.score - childScript51.score - childScript52.score - childScript53.score - childScript54.score - childScript55.score
                     - childScript56.score - childScript57.score - childScript58.score - childScript59.score - childScript60.score - childScript61.score
                      - childScript62.score - childScript63.score - childScript64.score - childScript65.score - childScript66.score - childScript67.score;

                if (displayScore == 0)
                {
                    orasphere.SetActive(false);
                    orasphere.transform.position = new Vector3(-3.62f, 0, 9.46f);
                    Cursor.visible = true;
                    scoreDisplayer.SetActive(false);
                    scoredisplayer2.SetActive(false);

                    //Helper.SetActive(false);
                    level5.SetActive(false);
                    winscreen.SetActive(true);
                    wintext.text = "Congratulations on clearing LEVEL 5!";
                    if (Castle.lives == 1)
                    {
                        heart1.SetActive(true);
                        heart2.SetActive(false);
                        heart3.SetActive(false);
                    }
                    else if (Castle.lives == 2)
                    {
                        heart1.SetActive(true);
                        heart2.SetActive(true);
                        heart3.SetActive(false);
                    }
                    else if (Castle.lives == 3)
                    {
                        heart1.SetActive(true);
                        heart2.SetActive(true);
                        heart3.SetActive(true);
                    }
                    TextTransfer.questionCount = 12;
                    StartCoroutine(Win51());
                    displayScore = 1000;
                }

                scoreText.text = displayScore.ToString();
                //Debug.Log(displayScore);
            }
        }

        



    }

    IEnumerator Win1()
    {
        yield return new WaitForSeconds(0f);
        if(winbutton == true)
        {
            Debug.Log("working?");
            winscreen.SetActive(false);
            Transition.SetActive(true);
            zombiecounthere = 1;
            Continue.lselected = false;
            winbutton = false;
            zombieScript00.score = 0;
            zombieScript01.score = 0;
            zombieScript02.score = 0;
            zombieScript03.score = 0;
            zombieScript04.score = 0;
            zombieScript05.score = 0;
            zombieScript06.score = 0;
            zombieScript07.score = 0;
        }
    }

    IEnumerator Win11()
    {
        yield return new WaitForSeconds(0f);
        if (winbutton == true)
        {            
            winscreen.SetActive(false);
            Transition.SetActive(true);
            zombiecounthere = 1;
            winbutton = false;
            zombieScript00.score = 0;
            zombieScript01.score = 0;
            zombieScript02.score = 0;
            zombieScript03.score = 0;
            zombieScript04.score = 0;
            zombieScript05.score = 0;
            zombieScript06.score = 0;
            zombieScript07.score = 0;
        }
        
    }
    IEnumerator Win21()
    {
        yield return new WaitForSeconds(0f);
        if (winbutton == true)
        {
            winscreen.SetActive(false);
            Transition.SetActive(true);
            zombiecounthere = 2;
            winbutton = false;
            zombieScript10.score = 0;
            zombieScript11.score = 0;
            zombieScript12.score = 0;
            zombieScript13.score = 0;
            zombieScript14.score = 0;
            zombieScript15.score = 0;
            zombieScript16.score = 0;
            zombieScript17.score = 0;
        }
    }
    IEnumerator Win31()
    {
        yield return new WaitForSeconds(0f);
        if (winbutton == true)
        {
            winscreen.SetActive(false);
            Transition.SetActive(true);
            zombiecounthere = 3;
            winbutton = false;
            zombieScript30.score = 0;
            zombieScript31.score = 0;
            zombieScript32.score = 0;
            zombieScript33.score = 0;
            zombieScript34.score = 0;
            zombieScript35.score = 0;
            zombieScript36.score = 0;
            zombieScript37.score = 0;
            zombieScript38.score = 0;
            zombieScript39.score = 0;
            childScript30.score = 0;
            childScript31.score = 0;
            childScript32.score = 0;
            childScript33.score = 0;

        }
    }
    IEnumerator Win41()
    {
        yield return new WaitForSeconds(0f);
        if (winbutton == true)
        {
            winscreen.SetActive(false);
            Transition.SetActive(true);
            zombiecounthere = 4;
            winbutton = false;
            zombieScript40.score = 0;
            zombieScript41.score = 0;
            zombieScript42.score = 0;
            zombieScript43.score = 0;
            zombieScript44.score = 0;
            zombieScript45.score = 0;
            zombieScript46.score = 0;
            zombieScript47.score = 0;
            zombieScript48.score = 0;
            zombieScript49.score = 0;
            childScript40.score = 0;
            childScript41.score = 0;
            childScript42.score = 0;
            childScript43.score = 0;
            childScript44.score = 0;
            childScript45.score = 0;
            childScript46.score = 0;
            childScript47.score = 0;
        }
    }
    IEnumerator Win51()
    {
        yield return new WaitForSeconds(0f);
        if (winbutton == true)
        {
            winscreen.SetActive(false);
            //Transition.SetActive(true);
            thanksscreen.SetActive(true);
            zombiecounthere = 5;
            winbutton = false;
            zombieScript50.score = 0;
            zombieScript51.score = 0;
            zombieScript52.score = 0;
            zombieScript53.score = 0;
            zombieScript54.score = 0;
            zombieScript55.score = 0;
            zombieScript56.score = 0;
            zombieScript57.score = 0;
            zombieScript58.score = 0;
            zombieScript59.score = 0;
            zombieScript60.score = 0;
            childScript50.score = 0;
            childScript51.score = 0;
            childScript52.score = 0;
            childScript53.score = 0;
            childScript54.score = 0;
            childScript55.score = 0;
            childScript56.score = 0;
            childScript57.score = 0;
            childScript58.score = 0;
            childScript59.score = 0;
            childScript60.score = 0;
            childScript61.score = 0;
            childScript62.score = 0;
            childScript63.score = 0;
            childScript64.score = 0;
            childScript65.score = 0;
            childScript66.score = 0;
            childScript67.score = 0;
        }
    }
    IEnumerator Win2()
    {
        yield return new WaitForSeconds(0f);
        if (winbutton == true)
        {
            winscreen.SetActive(false);
            Transition.SetActive(true);
            zombiecounthere = 2;
            Continue.lselected = false;
            winbutton = false;
            zombieScript10.score = 0;
            zombieScript11.score = 0;
            zombieScript12.score = 0;
            zombieScript13.score = 0;
            zombieScript14.score = 0;
            zombieScript15.score = 0;
            zombieScript16.score = 0;
            zombieScript17.score = 0;
        }
    }
    IEnumerator Win3()
    {
        yield return new WaitForSeconds(0f);
        if (winbutton == true)
        {
            winscreen.SetActive(false);
            Transition.SetActive(true);
            zombiecounthere = 3;
            Continue.lselected = false;
            winbutton = false;
            zombieScript30.score = 0;
            zombieScript31.score = 0;
            zombieScript32.score = 0;
            zombieScript33.score = 0;
            zombieScript34.score = 0;
            zombieScript35.score = 0;
            zombieScript36.score = 0;
            zombieScript37.score = 0;
            zombieScript38.score = 0;
            zombieScript39.score = 0;
            childScript30.score = 0;
            childScript31.score = 0;
            childScript32.score = 0;
            childScript33.score = 0;
        }
    }
    IEnumerator Win4()
    {
        yield return new WaitForSeconds(0f);
        if (winbutton == true)
        {
            winscreen.SetActive(false);
            Transition.SetActive(true);
            zombiecounthere = 4;
            Continue.lselected = false;
            winbutton = false;
            zombieScript40.score = 0;
            zombieScript41.score = 0;
            zombieScript42.score = 0;
            zombieScript43.score = 0;
            zombieScript44.score = 0;
            zombieScript45.score = 0;
            zombieScript46.score = 0;
            zombieScript47.score = 0;
            zombieScript48.score = 0;
            zombieScript49.score = 0;
            childScript40.score = 0;
            childScript41.score = 0;
            childScript42.score = 0;
            childScript43.score = 0;
            childScript44.score = 0;
            childScript45.score = 0;
            childScript46.score = 0;
            childScript47.score = 0;
        }
    }
    IEnumerator Win5()
    {
        yield return new WaitForSeconds(0f);
        if (winbutton == true)
        {
            winscreen.SetActive(false);
            thanksscreen.SetActive(true);
            //Transition.SetActive(true);
            zombiecounthere = 5;
            Continue.lselected = false;
            winbutton = false;
            zombieScript50.score = 0;
            zombieScript51.score = 0;
            zombieScript52.score = 0;
            zombieScript53.score = 0;
            zombieScript54.score = 0;
            zombieScript55.score = 0;
            zombieScript56.score = 0;
            zombieScript57.score = 0;
            zombieScript58.score = 0;
            zombieScript59.score = 0;
            zombieScript60.score = 0;
            childScript50.score = 0;
            childScript51.score = 0;
            childScript52.score = 0;
            childScript53.score = 0;
            childScript54.score = 0;
            childScript55.score = 0;
            childScript56.score = 0;
            childScript57.score = 0;
            childScript58.score = 0;
            childScript59.score = 0;
            childScript60.score = 0;
            childScript61.score = 0;
            childScript62.score = 0;
            childScript63.score = 0;
            childScript64.score = 0;
            childScript65.score = 0;
            childScript66.score = 0;
            childScript67.score = 0;
        }
    }

    public void WinButton()
    {
        winbutton = true;
        Debug.Log("winbutton is pressed");
    }

    public void Total()
    {
        z1 = zombieScript00.score + zombieScript01.score + zombieScript02.score + zombieScript03.score + zombieScript04.score + zombieScript05.score + zombieScript06.score + zombieScript07.score
            + zombieScript10.score + zombieScript11.score + zombieScript12.score + zombieScript13.score + zombieScript14.score +zombieScript30.score
            +zombieScript31.score+zombieScript32.score+zombieScript33.score+zombieScript34.score+ childScript30.score+childScript31.score+childScript32.score+childScript33.score
            +zombieScript40.score;
    }

}
