using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturntoPos5 : MonoBehaviour
{
    // Start is called before the first frame update
    public float x;
    public float y;
    public float z;
    private Zombie5 z1;
    private FauxGravityBody b;
    public GameObject parent;

    void Start()
    {
        z1 = this.GetComponent<Zombie5>();
        b = this.GetComponent<FauxGravityBody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (SceneChange.returntoPos == true)
        {
            this.transform.SetParent(parent.transform);
            this.transform.localPosition = new Vector3(x, y, z);
            z1.score = 0;
            //z1.speed = 0.2f;
            b.enabled = true;
            StartCoroutine(settoFalse());
        }

    }

    IEnumerator settoFalse()
    {
        yield return new WaitForSeconds(0.5f);
        //Debug.Log("hadipa5");
        SceneChange.returntoPos = false;
    }
}