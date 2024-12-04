using UnityEngine;

public class Dog : Animal
{
    protected override void Start()
    {
        base.Start();
        Debug.Log("Dog initialized!");
    }

    protected override void Update()
    {
        base.Update();
        // Dog-spezifische Logik kann hier eingefügt werden
    }
}
