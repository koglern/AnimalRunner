using UnityEngine;

public class SpeedPowerUp : PowerUp
{
    [Header("Speed Power-Up Settings")]
    [SerializeField] private float speedIncreaseAmount = 200f;

    protected override void ApplyEffect(Animal animal)
    {
        animal.speed += speedIncreaseAmount; // Increase the animal's speed
        Debug.Log(animal.name + " speed increased by " + speedIncreaseAmount);
    }

    protected override void RemoveEffect(Animal animal)
    {
        animal.speed -= speedIncreaseAmount; // Reset the speed
        Debug.Log(animal.name + " speed power-up effect removed.");
    }
}