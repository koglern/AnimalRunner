using UnityEngine;
using System.Collections;

public abstract class PowerUp : MonoBehaviour
{
    public float speed;
    protected Vector3 MoveDirection;
    
    [Header("Power-Up Settings")]
    [SerializeField] protected float duration = 5f; // Duration of the power-up effect

    protected virtual void  Start()
    {
        MoveDirection = new Vector3(0, 0, -1);
    }
    
    protected virtual void  Update()
    {
        Move();
        
        if (transform.position.z < -200)
        {
            Destroy(this);
        }
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Animal"))
        {
            Debug.Log("Collission with Obstacle");
            // Detect collision with an animal
            Animal animal = other.GetComponent<Animal>();
            if (animal != null)
            {
                ApplyEffect(animal); // Apply the effect to the animal
                StartCoroutine(RemovePowerUpAfterDuration(animal)); // Schedule removal
                GetComponent<Renderer>().enabled = false; // Hide the power-up
            }
            else
            {
                Debug.Log("Animal not found");
            }
        }
    }

    // Abstract methods for effect application and removal
    protected abstract void ApplyEffect(Animal animal);
    protected abstract void RemoveEffect(Animal animal);

    private IEnumerator RemovePowerUpAfterDuration(Animal animal)
    {
        yield return new WaitForSeconds(duration);
        
        Debug.Log("Remove Effect");
        RemoveEffect(animal); // Remove the effect after duration
        Destroy(gameObject); // Destroy the power-up object
    }
    
    protected virtual void Move()
    {
        //with space World we make sure, it always moves in the correct direction
        transform.Translate(MoveDirection * (speed * Time.deltaTime), Space.World);
    }
}