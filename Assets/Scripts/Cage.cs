using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cage : MonoBehaviour
{
    public GameObject cage;
    public GameObject tempCage;
    public TimeManager timeManager;
    public AudioSource cageAudio;
    public float time;
    public GameObject distantObject;

    void Start()
    {
        //Cursor.visible = false;
    }

    void Update()
    {
        SpawnAtMousePos();
        ShowCagePos();

        /*if (Input.GetKey(KeyCode.X))
        {
            timeManager.DoSlowMotion();
        }*/
    }

    private void SpawnAtMousePos()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if(Physics.Raycast(ray, out hit))
            {
                //Debug.Log("Hit");
                Instantiate(cage, hit.point, Quaternion.identity);
                cageAudio.Play();
                //StartCoroutine(TransferPos());
            }

            //This line of code does not work. Might work with some changes.
            /*Vector3 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Instantiate(cage, new Vector3(cursorPos.x, cursorPos.y, cursorPos.z), Quaternion.identity);*/

        }
    }

    private void ShowCagePos()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            //Debug.Log("Hit");
            tempCage.transform.position = hit.point;
        }

        else
        {
            tempCage.transform.position = Vector3.zero;
        }
    }

    public void SetCursorVisible()
    {
        //Cursor.lockState = CursorLockMode.locked;
        Cursor.visible = false;
    }

    private IEnumerator TransferPos()
    {
        //Debug.Log("transfer");
        yield return new WaitForSeconds(time);
        this.transform.position = distantObject.transform.position;

    }

}
