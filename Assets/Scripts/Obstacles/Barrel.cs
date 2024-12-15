using UnityEngine;

public class Barrel : Obstacle
{
    public float rotationForce;
    protected override void Start()
    {
        base.Start();
    }

    
    protected override void Update()
    {
        base.Update();
    }
    
    protected override void move() 
    {
        base.move();
        // Roll around the local X-axis (perpendicular to movement direction)
        transform.Rotate(Vector3.right * (rotationForce * Time.deltaTime), Space.Self);

        
    }

}
