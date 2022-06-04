using System;
using UnityEngine;
public class SmoothFollow : MonoBehaviour
{
    public Transform target;

    public float smoothness = 1f;

    public float rotationSmoothness = 0.1f;

    public Vector3 offset;

    private Vector3 velocity = Vector3.zero;

    private void FixedUpdate()
    {
        if (this.target == null)
        {
            return;
        }
        Vector3 vector = this.target.TransformDirection(this.offset);
        base.transform.position = Vector3.SmoothDamp(base.transform.position, vector, ref this.velocity, this.smoothness);
        Quaternion b = Quaternion.LookRotation(-base.transform.position.normalized, this.target.up);
        base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b, Time.deltaTime * this.rotationSmoothness);
    }
}