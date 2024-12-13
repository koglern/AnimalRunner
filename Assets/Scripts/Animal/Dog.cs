using UnityEngine;

public class Dog : Animal
{
    protected override void Start()
    {
        // Calls the Start() method implementation from the parent (base) class.
        base.Start();
        speed = 10.0f;
        
        Debug.Log("Dog initialized!");
    }

    protected override void Update()
    {
        base.Update();
        // Dog-spezifische Logik kann hier eingefügt werden
    }
}
