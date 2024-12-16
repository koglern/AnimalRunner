using UnityEngine;

// INHERITANCE: Dog class inherits from Animal
public class Horse : Animal
{
    protected override void Start()
    {
        // Calls the Start() method implementation from the parent (base) class.
        // POLYMORPHISM: Overriding the Start method from the Animal class
        base.Start();
        speed = 4.0f;
        Debug.Log("Horse initialized!");
    }

    protected override void Update()
    {
        //with base we access the baseclass
        // POLYMORPHISM: Overriding the Start method from the Animal class
        base.Update();
    }
}
