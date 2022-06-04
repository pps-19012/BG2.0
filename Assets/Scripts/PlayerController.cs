using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerController : MonoBehaviour
{
    public AudioSource crashAudio;
    public GameObject woosh;
    public GameObject wall;
    public float moveSpeed = 10f;
    public GameObject vehicle_original_pos;

    public float rotationSpeed = 10f;

    private float rotation;

    private Rigidbody rb;

    private void Start()
    {
        this.rb = base.GetComponent<Rigidbody>();
    }

    private void Update()
    {
        this.rotation = Input.GetAxisRaw("Horizontal");

        /*if (Input.GetKeyDown(KeyCode.Space))
        {
            moveSpeed = 20f;
        }*/
    }

    private void FixedUpdate()
    {
        this.rb.MovePosition(this.rb.position + base.transform.forward * this.moveSpeed * Time.fixedDeltaTime);
        Vector3 euler = Vector3.up * this.rotation * this.rotationSpeed * Time.fixedDeltaTime;
        Quaternion rhs = Quaternion.Euler(euler);
        Quaternion b = this.rb.rotation * rhs;
        this.rb.MoveRotation(Quaternion.Slerp(this.rb.rotation, b, 50f * Time.deltaTime));
    }

    private void BuildWall()
    {
        Vector3 spawnPosition = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z);
        Instantiate(wall, spawnPosition,transform.rotation);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Castle"))
        {
            //Debug.Log("woosh");
            crashAudio.Play();
            Instantiate(woosh, other.gameObject.transform.position, Quaternion.identity);
            this.transform.position = vehicle_original_pos.transform.position;
            //woosh.SetActive(true);
        }

        if (other.gameObject.CompareTag("Nitro"))
        {
            moveSpeed = 5f;
            StartCoroutine(normalSpeed());
        }
    }

    IEnumerator normalSpeed()
    {
        yield return new WaitForSeconds(3f);
        moveSpeed = 10f;
    }
    
}
