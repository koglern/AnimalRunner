using UnityEngine;


public class Moose : Animal
{
    protected override void Start()
    {
        base.Start();
        Debug.Log("Moose initialized!");
    }

    protected override void Update()
    {
        base.Update();
        // Moose-spezifische Logik kann hier eingefügt werden
    }
}