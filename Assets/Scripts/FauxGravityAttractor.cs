using System;
using UnityEngine;
public class FauxGravityAttractor : MonoBehaviour
{
    public static FauxGravityAttractor instance;

    private SphereCollider col;

    public float gravity = -10f;
    public float placeOnSurface;

    private void Awake()
    {
        FauxGravityAttractor.instance = this;
        this.col = base.GetComponent<SphereCollider>();
    }

    public void Attract(Rigidbody body)
    {
        Vector3 normalized = (body.position - base.transform.position).normalized;
        body.AddForce(normalized * this.gravity);
        this.RotateBody(body);
    }

    public void PlaceOnSurface(Rigidbody body)
    {
        body.MovePosition((body.position - base.transform.position).normalized * (base.transform.localScale.x * (this.col.radius-placeOnSurface)));
        this.RotateBody(body);
    }

    private void RotateBody(Rigidbody body)
    {
        Vector3 normalized = (body.position - base.transform.position).normalized;
        Quaternion b = Quaternion.FromToRotation(body.transform.up, normalized) * body.rotation;
        body.MoveRotation(Quaternion.Slerp(body.rotation, b, 50f * Time.deltaTime));
    }
}
