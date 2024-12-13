using UnityEngine;


public class Moose : Animal
{
    
    protected override void Start()
    {
        // Calls the Start() method implementation from the parent (base) class.
        base.Start();
        speed = 7.0f;
        
        Debug.Log("Moose initialized!");
    }

    protected override void Update()
    {
        base.Update();
        // Moose-spezifische Logik kann hier eingefügt werden
    }
}