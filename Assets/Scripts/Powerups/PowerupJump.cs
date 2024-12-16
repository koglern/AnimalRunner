using UnityEngine;

public class PowerupJump : PowerUp
{
    [Header("Jump Power-Up Settings")]
    [SerializeField] private float jumpIncreaseAmount = 5000f;

    protected override void ApplyEffect(Animal animal)
    {
        // Increase jump force
        animal.jumpForce += jumpIncreaseAmount; 
        Debug.Log(animal.name + " jump force increased by " + jumpIncreaseAmount);
    }

    protected override void RemoveEffect(Animal animal)
    {
        // Reset the jump force
        animal.jumpForce -= jumpIncreaseAmount; 
        Debug.Log(animal.name + " jump power-up effect removed.");
    }
}