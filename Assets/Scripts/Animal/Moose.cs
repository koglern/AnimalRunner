using UnityEngine;

// INHERITANCE: Dog class inherits from Animal
public class Moose : Animal
{
    
    protected override void Start()
    {
        // Calls the Start() method implementation from the parent (base) class.
        // POLYMORPHISM: Overriding the Start method from the Animal class
        base.Start();
        speed = 7.0f;
        
        Debug.Log("Moose initialized!");
    }

    protected override void Update()
    {
        // POLYMORPHISM: Overriding the Start method from the Animal class
        base.Update();
    }
}