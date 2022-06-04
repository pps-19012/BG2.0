using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class SceneChange : MonoBehaviour
{
    public static bool restart;
    public static bool returntoPos = false;
    //public int zombieCountHelper;
    //public int temphelper;
    public GameObject howtoplay2;
    public GameObject levelscreen;
    public static bool start_before_demo = false;
    public static bool howtoplayagain = false;
    public static int levelno = 0;

    public static bool boollevel1 = false;
    public static bool boollevel2 = false;
    public static bool boollevel3 = false;
    public static bool boollevel4 = false;
    public static bool boollevel5 = false;
    public GameObject level0;
    public GameObject level1;
    public GameObject level2;
    public GameObject level3;
    public GameObject level4;
    public GameObject level5;
    public GameObject everytimeUse;
    //public GameObject start;
    public GameObject restartMenu;
    public GameObject onetimeuse;
    public GameObject scorer;
    public GameObject scorer1;
    public GameObject cameramain;
    public GameObject camerainit;

    public GameObject pauseMenu;

    public GameObject zombieDisplay1;
    public GameObject zombieDisplay2;
    public GameObject zombieDisplay3;
    public GameObject zombieDisplay4;
    public GameObject zombieDisplay5;
    public GameObject zombie1text;
    public GameObject zombie0text;
    public GameObject zombie2text;
    public GameObject zombie3text;
    public GameObject zombie4text;
    public GameObject zombie5text;
    public GameObject onetimeUse;
    public GameObject menu;
    public GameObject continueButton;
    public TextMeshProUGUI startText;
    public TextMeshProUGUI quitText;
    public GameObject HowPlay;
    public GameObject start;
    private int hitcount = 0;
    public AudioSource startAudio;
    public AudioSource quitAudio;

    public Image level1button;
    public Image level2button;
    public Image level3button;
    public Image level4button;
    public Image level5button;

    public static bool levelselected;
    public string sceneName;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //zombieCountHelper = Continue.zombieCount;
    }

    public void PreviousScene()
    {
        SceneManager.LoadScene(sceneName);
    }

    public void StartGame()
    {
        levelselected = true;
        levelno = 0;
        returntoPos = true;
        startText.color = Color.white;
        startAudio.Play();
        //StartCoroutine(Yay());
        zombieDisplay1.SetActive(true);
        zombie1text.SetActive(true);
        start.SetActive(false);
        everytimeUse.SetActive(false);
        level0.SetActive(false);
        onetimeUse.SetActive(false);
        menu.SetActive(true);
        continueButton.SetActive(true);
        start_before_demo = true;
        restartMenu.SetActive(false);
        SceneChange.boollevel1 = true;
        level1button.GetComponent<Image>().color = Color.white;
    }

    public void Levels()
    {
        levelscreen.SetActive(true);
        start.SetActive(false);
        everytimeUse.SetActive(false);
        level0.SetActive(false);
        onetimeUse.SetActive(true);
    }

    public void QuitGame()
    {
        quitText.color = Color.white;
        quitAudio.Play();
        StartCoroutine(Heh());
        //Application.Quit();
    }

    IEnumerator Yay()
    {
        yield return new WaitForSeconds(1);
        start.SetActive(false);
        menu.SetActive(true);
    }

    IEnumerator Heh()
    {
        yield return new WaitForSeconds(1);
        Application.Quit();
    }

    public void HowtoPlay()
    {
        start.SetActive(false);
        onetimeUse.SetActive(false);
        everytimeUse.SetActive(false);
        camerainit.SetActive(true);
        levelselected = true;
        levelno = -1;
        levelscreen.SetActive(false);
        zombie0text.SetActive(true);
        menu.SetActive(true);
        continueButton.SetActive(true);
    }

    public void Back()
    {
        start.SetActive(true);
        HowPlay.SetActive(false);
    }

    public void Pause()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0.0f;
    }

    public void Resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1.0f;

    }

    public void Home()
    {
        //temphelper = zombieCountHelper;
        //howtoplayagain = true;
        pauseMenu.SetActive(false);
        Time.timeScale = 1.0f;
        level1.SetActive(false);
        level2.SetActive(false);
        level3.SetActive(false);
        level4.SetActive(false);
        level5.SetActive(false);
        everytimeUse.SetActive(false);
        scorer.SetActive(false);
        scorer1.SetActive(false);
        howtoplay2.SetActive(false);
        cameramain.SetActive(false);
        camerainit.SetActive(true);
        //Continue.zombieCount = temphelper;
        start.SetActive(true);
        onetimeUse.SetActive(true);
    }

    public void Restart()
    {
        //restart = true;
        Castle.lives = 4;
        restartMenu.SetActive(false);
        level1.SetActive(false);
        level2.SetActive(false);
        level3.SetActive(false);
        level4.SetActive(false);
        level5.SetActive(false);
        everytimeUse.SetActive(false);
        scorer.SetActive(false);
        scorer1.SetActive(false);

        cameramain.SetActive(false);
        camerainit.SetActive(true);
        start.SetActive(true);
        onetimeUse.SetActive(true);
    }

    public void Proceed()
    {
        //howtoplayagain = true;
        //returntoPos = true;
        levelscreen.SetActive(true);
        howtoplay2.SetActive(false);
        scorer.SetActive(false);
        scorer1.SetActive(false);

        everytimeUse.SetActive(false);
        cameramain.SetActive(false);
        level0.SetActive(false);
        camerainit.SetActive(true);
        onetimeUse.SetActive(true);
    }

    public void GoToLevel0()
    {
        //returntoPos = true;
        levelselected = true;
        //Debug.Log(SceneChange.levelselected);
        levelno = -1;
        levelscreen.SetActive(false);
        onetimeUse.SetActive(false);
        camerainit.SetActive(true);
        zombie0text.SetActive(true);
        menu.SetActive(true);
        continueButton.SetActive(true);
    }

    public void GoToLevel1()
    {
        //returntoPos = true;

        if (boollevel1 == true)
        {
            Debug.Log("boolevel1 is true");
            level1button.GetComponent<Image>().color = Color.white;
            levelselected = true;
            //Debug.Log(SceneChange.levelselected);
            levelno = 0;
            levelscreen.SetActive(false);
            onetimeUse.SetActive(false);
            camerainit.SetActive(true);
            zombieDisplay1.SetActive(true);
            zombie1text.SetActive(true);
            menu.SetActive(true);
            continueButton.SetActive(true);
        }
        
    }

    public void GoToLevel2()
    {
        //returntoPos = true;

        if (boollevel2 == true)
        {
            level2button.GetComponent<Image>().color = Color.white;
            levelselected = true;
            levelno = 1;
            levelscreen.SetActive(false);
            onetimeUse.SetActive(false);
            camerainit.SetActive(true);
            zombieDisplay2.SetActive(true);
            zombie2text.SetActive(true);
            menu.SetActive(true);
            continueButton.SetActive(true);
        }



    }

    public void GoToLevel3()
    {
        //returntoPos = true;

        if (boollevel3 == true)
        {
            level3button.GetComponent<Image>().color = Color.white;
            levelselected = true;
            levelno = 2;
            levelscreen.SetActive(false);
            onetimeUse.SetActive(false);
            camerainit.SetActive(true);
            zombieDisplay3.SetActive(true);
            zombie3text.SetActive(true);
            menu.SetActive(true);
            continueButton.SetActive(true);
        }

        

    }

    public void GoToLevel4()
    {
        //returntoPos = true;

        if (boollevel4 == true)
        {
            level4button.GetComponent<Image>().color = Color.white;
            levelselected = true;
            levelno = 3;
            levelscreen.SetActive(false);
            onetimeUse.SetActive(false);
            camerainit.SetActive(true);
            zombieDisplay4.SetActive(true);
            zombie4text.SetActive(true);
            menu.SetActive(true);
            continueButton.SetActive(true);
        }

        

    }

    public void GoToLevel5()
    {
        //returntoPos = true;

        if (boollevel5 == true)
        {
            level5button.GetComponent<Image>().color = Color.white;
            levelselected = true;
            levelno = 4;
            levelscreen.SetActive(false);
            onetimeUse.SetActive(false);
            camerainit.SetActive(true);
            zombieDisplay5.SetActive(true);
            zombie5text.SetActive(true);
            menu.SetActive(true);
            continueButton.SetActive(true);
        }

        

    }
}
