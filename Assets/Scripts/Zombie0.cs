using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie0 : MonoBehaviour
{
    public GameObject restartMenu;
    public GameObject distantObject;
    public GameObject blood;
    public GameObject parent;
    public GameObject Castle;
    public float speed;
    public int score;

    void Start()
    {
        transform.LookAt(Castle.transform);
    }


    void FixedUpdate()
    {
        transform.position = Vector3.MoveTowards(transform.position, Castle.transform.position, Time.deltaTime * speed);
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Castle") && HowToPlay.howtoplay == true)
        {
            //Debug.Log("Castle");
            //restartMenu.SetActive(true);
            score = 1;
            //Destroy(parent);
            this.transform.position = distantObject.transform.position;
        }

        if (other.gameObject.CompareTag("Cage") || other.gameObject.CompareTag("Cage2") && HowToPlay.howtoplay == true)
        {
            Instantiate(blood, other.gameObject.transform.position, Quaternion.identity);
            score = 1;
            //Debug.Log(score);
            //Debug.Log("Caged");
            //Destroy(parent);
            this.transform.position = distantObject.transform.position;
        }
        if (other.gameObject.CompareTag("Vehicle") && HowToPlay.howtoplay == true)
        {
            Instantiate(blood, other.gameObject.transform.position, Quaternion.identity);
            score = 1;
            //Debug.Log(score);
            //Debug.Log("Vehicle");
            //Destroy(parent);
            this.transform.position = distantObject.transform.position;
        }


    }
}
