using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Castle : MonoBehaviour
{
    public static int lives = 3;
    public GameObject level0;
    public GameObject level1;
    public GameObject level2;
    public GameObject level3;
    public GameObject level4;
    public GameObject level5;
    public TextMeshProUGUI scoreText;
    public GameObject scoreDisplayer;
    public GameObject restartMenu;
    public GameObject heart1;
    public GameObject heart2;
    public GameObject heart3;

    // Start is called before the first frame update
    void Start()
    {
        scoreText = scoreDisplayer.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = lives.ToString();
        if (lives == 0)
        {
            restartMenu.SetActive(true);
            level0.SetActive(false);
            level1.SetActive(false);
            level2.SetActive(false);
            level3.SetActive(false);
            level4.SetActive(false);
            level5.SetActive(false);
            heart1.SetActive(false);
            heart2.SetActive(false);
            heart3.SetActive(false);
            /*if(SceneChange.restart == true)
            {
                lives = 3;
                SceneChange.restart = false;
            }*/
        }
        if(lives == 1)
        {
            heart1.SetActive(true);
            heart2.SetActive(false);
            heart3.SetActive(false);
        }
        if(lives == 2)

        {
            heart1.SetActive(true);
            heart2.SetActive(true);
            heart3.SetActive(false);
        }
        if (lives > 3)
        {
            lives = 3;
            heart1.SetActive(true);
            heart2.SetActive(true);
            heart3.SetActive(true);
        }

    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Zombie"))
        {
            lives = lives - 1;
        }
    }

}
