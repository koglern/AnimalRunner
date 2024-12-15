using UnityEngine;

public class PowerupJump : PowerUp
{
    [Header("Jump Power-Up Settings")]
    [SerializeField] private float jumpIncreaseAmount = 5000f;

    protected override void ApplyEffect(Animal animal)
    {
        animal.jumpForce += jumpIncreaseAmount; // Increase jump force
        Debug.Log(animal.name + " jump force increased by " + jumpIncreaseAmount);
    }

    protected override void RemoveEffect(Animal animal)
    {
        animal.jumpForce -= jumpIncreaseAmount; // Reset the jump force
        Debug.Log(animal.name + " jump power-up effect removed.");
    }
}