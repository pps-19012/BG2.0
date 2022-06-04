using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    public GameObject restartMenu;
    public GameObject distantObject;
    public GameObject blood;
    public GameObject parent;
    public GameObject Castle;
    private FauxGravityBody b;
    public float speed;
    public int score;

    void Start()
    {
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
            //Debug.Log("Castle");
            //restartMenu.SetActive(true);
            score = 1;
            b.enabled = false;
            //speed = 0;
            this.transform.position = distantObject.transform.position;
        }

        if (other.gameObject.CompareTag("Cage") || other.gameObject.CompareTag("Cage2"))
        {
            Instantiate(blood, other.gameObject.transform.position, Quaternion.identity);
            score = 1;
            //Debug.Log(score);
            //Debug.Log("Caged");
            //Destroy(parent);
            b.enabled = false;
            //speed = 0;
            this.transform.position = distantObject.transform.position;
        }
        if (other.gameObject.CompareTag("Vehicle"))
        {
            Instantiate(blood, other.gameObject.transform.position, Quaternion.identity);
            score = 1;
            //Debug.Log(score);
            //Debug.Log("Vehicle");
            //Destroy(parent);
            b.enabled = false;
            //speed = 0;
            this.transform.position = distantObject.transform.position;
        }


    }
}
