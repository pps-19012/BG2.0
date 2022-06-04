using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie3 : MonoBehaviour
{
    public GameObject restartMenu;
    public GameObject distantObject;
    public GameObject level3;
    public GameObject blood;
    public GameObject parent;
    public GameObject parent1;
    public GameObject Castle;
    public GameObject zombie1;
    public GameObject child1;
    public GameObject child2;
    public GameObject magic;
    private FauxGravityBody b;
    public float speed;
    private float tempSpeed;
    public int score;
    public int breakTime;

    void Start()
    {
        transform.LookAt(Castle.transform);
        b = this.GetComponent<FauxGravityBody>();
        //child1.SetActive(false);
        //child2.SetActive(false);
    }


    void FixedUpdate()
    {
        transform.position = Vector3.MoveTowards(transform.position, Castle.transform.position, Time.deltaTime * speed);

        /*if(score == -1)
        {
            child1.transform.SetParent(level3.transform);
            child2.transform.SetParent(level3.transform);
            child1.SetActive(true);
            child2.SetActive(true);
        }*/

        if(score == 0)
        {
            child1.SetActive(false);
            child2.SetActive(false);
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Castle"))
        {
            //Debug.Log("Castle");
            //restartMenu.SetActive(true);
            score = 1;
            //Destroy(parent1);
            //speed = 0;
            b.enabled = false;
            this.transform.position = distantObject.transform.position;
        }

        if (other.gameObject.CompareTag("Cage"))
        {
            score = -1;
            Instantiate(blood, other.gameObject.transform.position, Quaternion.identity);
            child1.transform.SetParent(level3.transform);
            child2.transform.SetParent(level3.transform);
            child1.SetActive(true);
            child2.SetActive(true);
            //Destroy(parent1);
            //speed = 0;
            b.enabled = false;
            this.transform.position = distantObject.transform.position;

        }
        /*if (other.gameObject.CompareTag("Cage2"))
        {
            Instantiate(blood, other.gameObject.transform.position, Quaternion.identity);
            score += 10;
            Debug.Log(score);
            Debug.Log("Caged");
            Destroy(parent);
        }*/
        if (other.gameObject.CompareTag("Vehicle"))
        {
            //Debug.Log("Vehicle");
            Instantiate(blood, other.gameObject.transform.position, Quaternion.identity);
            score = 1;
            //Destroy(parent1);
            //speed = 0;
            b.enabled = false;
            this.transform.position = distantObject.transform.position;
        }


    }

    /*private IEnumerator Break()
    {
        tempSpeed = speed;
        speed = 0;
        yield return new WaitForSeconds(breakTime);
        speed = tempSpeed;
    }*/

    /*private IEnumerator Multiply()
    {
        
    }*/
}
