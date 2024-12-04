using UnityEngine;

public class Horse : Animal
{
    protected override void Start()
    {
        base.Start();
        Debug.Log("Horse initialized!");
    }

    protected override void Update()
    {
        //with base we access the baseclass
        base.Update();
        // Horse-spezifische Logik kann hier eingefügt werden
    }
}
