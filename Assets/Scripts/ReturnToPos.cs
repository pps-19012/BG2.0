using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnToPos : MonoBehaviour
{
    public float x;
    public float y;
    public float z;
    private Zombie0 z0;

    void Start()
    {
        z0 = this.GetComponent<Zombie0>();
    }

    // Update is called once per frame
    void Update()
    {
        if (SceneChange.returntoPos == true)
        {
            this.transform.localPosition = new Vector3(x, y, z);
            z0.score = 0;
            StartCoroutine(settoFalse());
        }
        
    }

    IEnumerator settoFalse()
    {
        yield return new WaitForSeconds(0.5f);
        //Debug.Log("hadipa0");
        SceneChange.returntoPos = false;
    }
}
