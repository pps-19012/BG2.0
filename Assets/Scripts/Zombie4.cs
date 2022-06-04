using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie4 : MonoBehaviour
{
    public GameObject restartMenu;
    public GameObject distantObject;
    public GameObject blood;
    public GameObject level4;
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
    }


    void FixedUpdate()
    {
        transform.position = Vector3.MoveTowards(transform.position, Castle.transform.position, Time.deltaTime * speed);

        if (score == 0)
        {
            child1.SetActive(false);
            child2.SetActive(false);
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Castle"))
        {
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
            child1.transform.SetParent(level4.transform);
            child2.transform.SetParent(level4.transform);
            child1.SetActive(true);
            child2.SetActive(true);
            //Destroy(parent1);
            //speed = 0;
            b.enabled = false;
            this.transform.position = distantObject.transform.position;


            //Destroy(parent);
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
}