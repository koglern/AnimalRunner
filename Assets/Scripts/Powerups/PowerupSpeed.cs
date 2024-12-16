using UnityEngine;

public class SpeedPowerUp : PowerUp
{
    [Header("Speed Power-Up Settings")]
    [SerializeField] private float speedIncreaseAmount = 200f;

    protected override void ApplyEffect(Animal animal)
    {
        // Increase the animal's speed
        animal.speed += speedIncreaseAmount; 
        Debug.Log(animal.name + " speed increased by " + speedIncreaseAmount);
    }

    protected override void RemoveEffect(Animal animal)
    {
        // Reset the speed
        animal.speed -= speedIncreaseAmount; 
        Debug.Log(animal.name + " speed power-up effect removed.");
    }
}