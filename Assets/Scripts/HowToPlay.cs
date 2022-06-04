using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HowToPlay : MonoBehaviour
{
    public GameObject howtoplayui;
    public GameObject level0;
    public GameObject scorebd;
    public GameObject scoreb;
    public GameObject scorea;
    public GameObject goodluck;
    public GameObject proceed;
    public GameObject cong;

    private int zombienum;
    private int score;

    public GameObject vehicle;
    public GameObject vehiclePos;

    public GameObject zombiesp1;
    public GameObject zombiesp2;
    public GameObject zombiesp3;
    public GameObject zombiesp4;

    public float time1;
    public float time2;
    public float time3;
    public float time4;
    public float time5;
    public float waitTime;

    public GameObject ad;
    public GameObject pointer;
    public GameObject zb;

    private bool b1 = false;
    private bool b2 = false;
    private bool b3 = false;
    private bool b4 = false;
    private bool b5 = false;
    public static bool howtoplay;

    public bool htp;
    //private bool flag = true;

    // Start is called before the first frame update
    void Start()
    {
        //vehicle.GetComponent<PlayerController>().enabled = false;
        //flag = true;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(score);
        //zombienum = Score.zombiecounthere;

        score = Score.displayScore;

        if (SceneChange.howtoplayagain == true)
        {
            b1 = false;
            b2 = false;
            b3 = false;
            b4 = false;
            b5 = false;
            //howtoplayui.SetActive(false);
            //level0.SetActive(false);
            scorebd.SetActive(true);
            howtoplay = false;
            ad.SetActive(false);
            pointer.SetActive(false);
            zb.SetActive(false);
            scorea.SetActive(false);
            scoreb.SetActive(false);
            goodluck.SetActive(false);
            zombiesp1.SetActive(false);
            zombiesp2.SetActive(false);
            zombiesp3.SetActive(false);
            zombiesp4.SetActive(false);
            cong.SetActive(false);
            proceed.SetActive(false);
            SceneChange.howtoplayagain = false;
        }

        /*if(SceneChange.howtoplayagain == true)
        {
            cong.SetActive(false);
            proceed.SetActive(false);
        }*/

        //htp = SceneChange.howtoplayagain;

        else if (b1 == false)
        {
            StartCoroutine(control1());
        }

        else if(b1 == true && b2==false)
        {
            //Time.timeScale = 1.0f;
            Check();
        }

        else if (b1 == true && b2 == true && b3==false)
        {
            //Time.timeScale = 1.0f;
            Check2();
        }

        else if (b1 == true && b2 == true && b3 == true && b4 == false)
        {
            //Time.timeScale = 1.0f;
            Check3();
        }

        else if (b1 == true && b2 == true && b3 == true && b4 == true && b5 == false)
        {
            //Time.timeScale = 1.0f;
            //howtoplay = true;
            Check4();
        }
        else if (b1 == true && b2 == true && b3 == true && b4 == true && b5 == true)
        {
            //Time.timeScale = 1.0f;
            Check5();
        }

        
    }

    IEnumerator control1()
    {
        yield return new WaitForSeconds(time1);
        ad.SetActive(true);
        b1 = true;

    }

    IEnumerator control2()
    {
        yield return new WaitForSeconds(time2);
        //Time.timeScale = 0.0f;
        ad.SetActive(false);
        pointer.SetActive(true);
        b2 = true;
    }

    IEnumerator control3()
    {
        yield return new WaitForSeconds(time3);
        ad.SetActive(false);
        pointer.SetActive(false);
        zb.SetActive(true);
        b3 = true;
        //Time.timeScale = 0.0f;
    }

    IEnumerator control4()
    {
        yield return new WaitForSeconds(time4);
        ad.SetActive(false);
        pointer.SetActive(false);
        zb.SetActive(false);
        //Debug.Log("zb done");
        scorea.SetActive(true);
        scoreb.SetActive(true);
        b4 = true;
        howtoplay = true;
    }

    IEnumerator control5()
    {
        yield return new WaitForSeconds(time5);
        ad.SetActive(false);
        pointer.SetActive(false);
        zb.SetActive(false);
        scorea.SetActive(false);
        scoreb.SetActive(false);
        goodluck.SetActive(false);
        b5 = true;
    }

    IEnumerator wait()
    {
        yield return new WaitForSeconds(waitTime);
        vehicle.transform.position = vehiclePos.transform.position;
        zombiesp1.SetActive(true);
        zombiesp2.SetActive(true);
        zombiesp3.SetActive(true);
        zombiesp4.SetActive(true);
        StartCoroutine(control3());

    }

    IEnumerator wait1()
    {
        yield return new WaitForSeconds(waitTime);
    }

    void Check()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            ad.SetActive(false);
            StartCoroutine(control2());
        }
    }

    void Check2()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            pointer.SetActive(false);
            StartCoroutine(wait());
        }
    }

    void Check3()
    {
        StartCoroutine(control4());
    }

    void Check4()
    {
        if(score == 2 || score == 1)
        {
            scorea.SetActive(false);
            scoreb.SetActive(false);
            goodluck.SetActive(true);
            StartCoroutine(control5());
        }
    }

    void Check5()
    {
        if(score == 3)
        {
            Debug.Log("proceed");
            cong.SetActive(true);
            proceed.SetActive(true);
        }
    }
}
