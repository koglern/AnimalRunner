using System;
using UnityEngine;

public class Boulder : Obstacle
{
    private Rigidbody _rb;
    public float moveForce;

    protected override void Start()
    {
        base.Start();
        _rb = GetComponent<Rigidbody>();
    }


    protected override void Update()
    {
        base.Update();
    }

    protected override void move() 
    {
        _rb.AddForce(base._moveDirection * moveForce, ForceMode.Force);
        
    }
}
