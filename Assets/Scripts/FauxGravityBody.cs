using System;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class FauxGravityBody : MonoBehaviour
{
    private FauxGravityAttractor attractor;

    private Rigidbody rb;

    public bool placeOnSurface;

    private void Start()
    {
        this.rb = base.GetComponent<Rigidbody>();
        this.attractor = FauxGravityAttractor.instance;
    }

    private void FixedUpdate()
    {
        if (this.placeOnSurface)
        {
            this.attractor.PlaceOnSurface(this.rb);
        }
        else
        {
            this.attractor.Attract(this.rb);
        }
    }
}
