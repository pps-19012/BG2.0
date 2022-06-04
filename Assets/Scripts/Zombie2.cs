using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie2 : MonoBehaviour
{
    public GameObject restartMenu;
    public GameObject distantObject;
    private int cageno;
    private int cageno2;
    public GameObject blood;
    public GameObject parent;
    public GameObject Castle;
    public float speed;
    private float tempSpeed;
    public int score;
    public int breakTime;
    private FauxGravityBody b;

    void Start()
    {
        cageno = 0;
        cageno2 = 0;
        transform.LookAt(Castle.transform);
        b = this.GetComponent<FauxGravityBody>();
    }


    void FixedUpdate()
    {
        transform.position = Vector3.MoveTowards(transform.position, Castle.transform.position, Time.deltaTime * speed);
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Castle"))
        {
            score = 1;
            //Destroy(parent);
            b.enabled = false;
            //speed = 0;
            this.transform.position = distantObject.transform.position;
        }

        else if (other.gameObject.CompareTag("Cage"))
        {
            if(cageno == 0)
            {
                StartCoroutine(Break());
                cageno = 1;
            }

            else if(cageno == 1)
            {
                StartCoroutine(Break());
                cageno = 2;
            }

            else if(cageno == 2)
            {
                Instantiate(blood, other.gameObject.transform.position, Quaternion.identity);
                score = 1;
                //Destroy(parent);
                b.enabled = false;
                //speed = 0;
                this.transform.position = distantObject.transform.position;
            }
        }
        /*else if (other.gameObject.CompareTag("Cage2"))
        {
            Instantiate(blood, other.gameObject.transform.position, Quaternion.identity);
            score = 1;
            Destroy(parent);
        }*/
        else if (other.gameObject.CompareTag("Vehicle"))
        {
            if(cageno2 == 0)
            {
                cageno2 = 1;
            }

            else if(cageno2 == 1)
            {
                cageno2 = 2;
            }

            else if (cageno2 == 2)
            {
                Instantiate(blood, other.gameObject.transform.position, Quaternion.identity);
                score = 1;
                //Destroy(parent);
                b.enabled = false;
                //speed = 0;
                this.transform.position = distantObject.transform.position;
            }
            
        }


    }

    private IEnumerator Break()
    {
        tempSpeed = speed;
        speed = 0;  
        yield return new WaitForSeconds(breakTime);
        speed = tempSpeed;
    }
}
