using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level0 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject o1;
    public GameObject o2;
    public GameObject o3;

    void Start()
    {
        o1.transform.position = new Vector3(9.87f, 0.56f, -1.009852f);
        o2.transform.position = new Vector3(-9.76f, 0.26f, 0.75f);
        o3.transform.position = new Vector3(7.37f, -3.63f, 5.48f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
