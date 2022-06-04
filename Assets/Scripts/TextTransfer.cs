using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextTransfer : MonoBehaviour
{
    [SerializeField]
    private string BASE_URL = "https://docs.google.com/forms/u/0/d/e/1FAIpQLSeIF_IDgGXgd80StH7GOTUeQsV7qbSt2Qn3JD6Ff9oH_RwPqw/formResponse";

    public GameObject everytimeuse;

    public GameObject transitionConti;
    public GameObject initcam;
    public GameObject mancam;
    public GameObject zombshow;
    public GameObject thanksScreen;

    //Display2
    public GameObject zombie2;
    public GameObject zombie2Text;

    //Display3
    public GameObject zombie3;
    public GameObject zombie3Text;

    public GameObject zombie4;
    public GameObject zombie4Text;
    public GameObject zombie5;
    public GameObject zombie5Text;

    public GameObject zombie1;
    public GameObject zombie1Text;

    public string answer00;
    public string answer01;
    public string answer02;
    public string answer10;
    public string answer11;
    public string answer12;
    public string answer20;
    public string answer21;
    public string answer22;
    public string answer30;
    public string answer31;
    public string answer32;
    public string answer40;
    public string answer41;
    public string answer42;
    public string question;

    public string reviewQuestion;
    public TMP_InputField eraseField;
    public static int questionCount = 0;
    public int reviewCount = 0;

    public GameObject Continue;
    public GameObject Transit;
    public GameObject inputField;

    public GameObject questionText;

    public GameObject orangeSphere;
    public GameObject scoreshower;
    //public GameObject scoreshower1;
    public GameObject level1;
    public GameObject level2;
    public GameObject level3;
    public GameObject level4;
    public GameObject level5;
    private int continueCount = 0;
 

    void Update()
    {
        eraseField.characterLimit = 300;
        continueCount = Score.zombiecounthere;
    }
    public void DisplayQuestion()
    {
        //Zombie1 = copycat cathy
        if(questionCount == 0)
        {
            question = "How can you help your friend with homework?";
            questionCount = 1;
        }
        else if (questionCount == 1)
        {
            question = "Can you say NO to a friend who is trying to take away your hard work?";
            //questionCount = 2;
        }

        else if (questionCount == 2)
        {
            question = "Tell us how you will make your friend understand?";
            //questionCount = 3;
        }

        //Zombie2 = loaner levi
        else if (questionCount == 3)
        {
            question = "How can you share your things without selfishness?";
        }
        else if (questionCount == 4)
        {
            question = "Can you say NO when a friend constantly asks for things without thinking about your needs?";
        }
        else if (questionCount == 5)
        {
            question = "Tell us how you will make your friend understand?";
        }

        //Zombie3 = joker jaga
        else if (questionCount == 6)
        {
            question = "How will you make your friend understand that a comment or joke is feeling hurtful?";
        }
        else if (questionCount == 7)
        {
            question = "Can you say NO to your friend who is making you feel bad about yourself?";
        }
        else if (questionCount == 8)
        {
            question = "Tell us how you will make your friend understand?";
        }

        //Zombie4 = emo eashwari
        else if(questionCount == 9)
        {
            question = "How can you be a good listener to your friend who wants to share her problems?";
        }
        else if (questionCount == 10)
        {
            question = "Can you say NO to a friend who makes you feel uncomfortable when sharing her life details?";
        }
        else if (questionCount == 11)
        {
            question = "Tell us how you will make your friend understand?";
        }

        //Zombie5 = chi chi chacha
        else if (questionCount == 12)
        {
            question = "How much do you feel is acceptable for your relatives to get close to you?";
        }
        else if (questionCount == 13)
        {
            question = "Can you say NO to an uncle who touches you in the wrong places?";
        }
        else if (questionCount == 14)
        {
            question = "Tell us how you will notify about this bad uncle to your trusted elders (mom/dad)";
        }

        //questionCount++;
        questionText.GetComponent<TextMeshProUGUI>().text = question;
        Debug.Log(questionCount);

    }
    public void StoreText()
    {
        //eraseField.characterLimit = 100;

        if (questionCount == 0)
        {
            answer00 = inputField.GetComponent<TextMeshProUGUI>().text;
            if (answer00.Length > 80)
            {
                Debug.Log("answer00.Length = " + answer00.Length);
                questionCount = 1;
            }
            
        }
        else if (questionCount == 1)
        {
            answer01 = inputField.GetComponent<TextMeshProUGUI>().text;
            if (answer01.Length > 80)
            {
                
                questionCount = 2;
            }

        }
        else if (questionCount == 2)
        {
            answer02 = inputField.GetComponent<TextMeshProUGUI>().text;
            if (answer02.Length > 80)
            {
                
                questionCount = 3;
                eraseField.text = "";
                Transit.SetActive(false);
                Castle.lives += 1;
                //Destroy(Transit);
                Continue.SetActive(true);
            }
            

        }
        else if (questionCount == 3)
        {
            answer10 = inputField.GetComponent<TextMeshProUGUI>().text;
            if (answer10.Length > 80)
            {
                
                questionCount = 4;
            }

        }
        else if (questionCount == 4)
        {
            answer11 = inputField.GetComponent<TextMeshProUGUI>().text;
            if (answer11.Length > 80)
            {
                
                questionCount = 5;
            }
        }
        else if (questionCount == 5)
        {
            answer12 = inputField.GetComponent<TextMeshProUGUI>().text;
            if (answer12.Length > 80)
            {
                
                questionCount = 6;
                eraseField.text = "";
                Transit.SetActive(false);
                Castle.lives += 1;
                Continue.SetActive(true);
            }
            
        }
        else if (questionCount == 6)
        {
            answer20 = inputField.GetComponent<TextMeshProUGUI>().text;
            if (answer20.Length > 80)
            {
                
                questionCount = 7;
            }
            
        }
        else if (questionCount == 7)
        {
            answer21 = inputField.GetComponent<TextMeshProUGUI>().text;
            if (answer21.Length > 80)
            {
                
                questionCount = 8;
            }
        }
        else if (questionCount == 8)
        {
            answer22 = inputField.GetComponent<TextMeshProUGUI>().text;
            if (answer22.Length > 80)
            {
                
                eraseField.text = "";
                Transit.SetActive(false);
                Castle.lives += 1;
                Continue.SetActive(true);
                questionCount = 9;
            }
            
        }
        else if (questionCount == 9)
        {
            answer30 = inputField.GetComponent<TextMeshProUGUI>().text;
            if (answer30.Length > 80)
            {
                
                questionCount = 10;
            }
        }
        else if(questionCount == 10)
        {
            answer31 = inputField.GetComponent<TextMeshProUGUI>().text;
            if (answer31.Length > 80)
            {
                
                questionCount = 11;
            }
        }
        else if(questionCount == 11)
        {
            answer32 = inputField.GetComponent<TextMeshProUGUI>().text;
            if (answer32.Length > 80)
            {
                
                eraseField.text = "";
                Transit.SetActive(false);
                Castle.lives += 1;
                Continue.SetActive(true);
                questionCount = 12;
            }
        }
        else if(questionCount == 12)
        {
            answer40 = inputField.GetComponent<TextMeshProUGUI>().text;
            if (answer40.Length > 80)
            {
                
                questionCount = 13;
            }
        }
        else if(questionCount == 13)
        {
            answer41 = inputField.GetComponent<TextMeshProUGUI>().text;
            if (answer41.Length > 80)
            {
                
                questionCount = 14;
            }
        }
        else if(questionCount == 14)
        {
            answer42 = inputField.GetComponent<TextMeshProUGUI>().text;
            if (answer42.Length > 80)
            {
                
                eraseField.text = "";
                Transit.SetActive(false);
                Castle.lives += 1;
                Continue.SetActive(true);
                //questionCount = 15;
            }

        }

        eraseField.text = "";
    }

    public void ContinueNormalGame()
    {
        Debug.Log(continueCount);

        if(continueCount == 1)
        {
            //scoreshower.SetActive(true);
            level1.SetActive(false);
            //continueCount = 1;

            zombshow.SetActive(true);
            initcam.SetActive(true);
            mancam.SetActive(false);
            everytimeuse.SetActive(false);
            Continue.SetActive(false);
            transitionConti.SetActive(true);
            zombie2Text.SetActive(true);
            zombie2.SetActive(true);
        }
        else if(continueCount == 2)
        {
            //Transition.SetActive(true);
            //scoreshower.SetActive(true);
            level2.SetActive(false);
            //continueCount = 2;

            zombshow.SetActive(true);
            initcam.SetActive(true);
            mancam.SetActive(false);
            everytimeuse.SetActive(false);
            Continue.SetActive(false);
            transitionConti.SetActive(true);
            zombie3Text.SetActive(true);
            zombie3.SetActive(true);

            /*level3.SetActive(true);
            Cursor.visible = false;*/
        }

        else if (continueCount == 3)
        {
            //Transition.SetActive(true);
            //scoreshower.SetActive(true);
            level3.SetActive(false);
            //continueCount = 2;

            zombshow.SetActive(true);
            initcam.SetActive(true);
            mancam.SetActive(false);
            everytimeuse.SetActive(false);
            Continue.SetActive(false);
            transitionConti.SetActive(true);
            zombie4Text.SetActive(true);
            zombie4.SetActive(true);

            /*level3.SetActive(true);
            Cursor.visible = false;*/
        }

        else if (continueCount == 4)
        {
            //Transition.SetActive(true);
            //scoreshower.SetActive(true);
            level4.SetActive(false);
            //continueCount = 2;

            zombshow.SetActive(true);
            initcam.SetActive(true);
            mancam.SetActive(false);
            everytimeuse.SetActive(false);
            Continue.SetActive(false);
            transitionConti.SetActive(true);
            zombie5Text.SetActive(true);
            zombie5.SetActive(true);

            /*level3.SetActive(true);
            Cursor.visible = false;*/
        }

        else if (continueCount == 5)
        {
            //Transition.SetActive(true);
            //scoreshower.SetActive(true);
            level5.SetActive(false);
            //continueCount = 2;

            zombshow.SetActive(true);
            initcam.SetActive(true);
            mancam.SetActive(false);
            everytimeuse.SetActive(false);
            Continue.SetActive(false);
            transitionConti.SetActive(true);
            //zombie5Text.SetActive(true);
            //zombie5.SetActive(true);

            /*level3.SetActive(true);
            Cursor.visible = false;*/
        }

        WWWForm form = new WWWForm();
        form.AddField("entry.172268075", answer00);
        form.AddField("entry.1509528663", answer01);
        form.AddField("entry.1657231702", answer02);
        form.AddField("entry.1972740044", answer10);
        form.AddField("entry.1498026918", answer11);
        form.AddField("entry.1853714144", answer12);
        form.AddField("entry.1755727282", answer20);
        form.AddField("entry.1607292477", answer21);
        form.AddField("entry.772219305", answer22);
        form.AddField("entry.1385959831", answer30);
        form.AddField("entry.802820837", answer31);
        form.AddField("entry.710388713", answer32);
        form.AddField("entry.1044691072", answer40);
        form.AddField("entry.1547684701", answer41);
        form.AddField("entry.702336615", answer42);
        byte[] rawData = form.data;
        WWW www = new WWW(BASE_URL, rawData);

    }
}
