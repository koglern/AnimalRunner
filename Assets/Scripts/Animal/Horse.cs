using UnityEngine;

public class Horse : Animal
{
    protected override void Start()
    {
        // Calls the Start() method implementation from the parent (base) class.
        base.Start();
        speed = 4.0f;
        Debug.Log("Horse initialized!");
    }

    protected override void Update()
    {
        //with base we access the baseclass
        base.Update();
        // Horse-spezifische Logik kann hier eingefügt werden
    }
}
