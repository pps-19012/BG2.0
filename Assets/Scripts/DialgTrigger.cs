using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialgTrigger : MonoBehaviour
{
    public Dialogue dialogue;
    public GameObject nextButton;
    public AudioSource aud0;
    //public GameObject captain;
    public GameObject messageBox;
    //public GameObject call;
    //public AudioSource callnoise;

    public void TriggerDialogue()
    {
        //FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
        //captain.SetActive(true);
        messageBox.SetActive(true);
        StartCoroutine(Yay());
        aud0.Play();
        StartCoroutine(Hmm());
        //call.SetActive(false);
        //call.transform.position = new Vector3(223202, 125596, 0);
        //callnoise.Stop();
        //nextButton.SetActive(true);

    }

    IEnumerator Yay()
    {
        yield return new WaitForSeconds(0.5f);
        //FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }

    IEnumerator Hmm()
    {
        yield return new WaitForSeconds(3);
        nextButton.SetActive(true);
    }
}
