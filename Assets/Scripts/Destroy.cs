using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    // Start is called before the first frame update
    public float time;
    public GameObject distantObject;
    public FauxGravityBody itself;

    void Start()
    {
        //Destroy(this.gameObject, time);
        itself = this.GetComponent<FauxGravityBody>();
        StartCoroutine(Die());
    }

    // Update is called once per frame
    void Update()
    {
    }

    private IEnumerator Die()
    {
        //Do something

        yield return new WaitForSeconds(time);
        this.transform.position = distantObject.transform.position;
        itself.enabled = false;
        //this.transform.position = new Vector3(9999, 9999, 9999);
        //Destroy(gameObject, time);
    }
}
