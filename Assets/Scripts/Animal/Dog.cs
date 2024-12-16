using UnityEngine;

// INHERITANCE: Dog class inherits from Animal
public class Dog : Animal
{
    protected override void Start()
    {
        // Calls the Start() method implementation from the parent (base) class.
        // POLYMORPHISM: Overriding the Start method from the Animal class
        base.Start();
        speed = 10.0f;
        
        Debug.Log("Dog initialized!");
    }

    protected override void Update()
    {
        // POLYMORPHISM: Overriding the Start method from the Animal class
        base.Update();
    }
}
