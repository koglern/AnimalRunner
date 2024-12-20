using System;
using UnityEngine;
using UnityEngine.UI;
public class Animal : MonoBehaviour
{
    [Header("Movement Settings")]
    public float speed = 2.5f; //standard speed, can be overriden in child classes
    public float jumpForce = 5f;
    public float boundaryRight = 15f;
    public float boundaryLeft = -15f;
    public bool isOnGround = true;

    [SerializeField] private GameObject gameOverPopup;
    
    private float _horizontalInput;
    private Vector3 _animalPosition;
    protected Rigidbody rb;
    
    protected virtual void Start()
    {
        rb = GetComponent<Rigidbody>();
        if (rb == null)
        {
            Debug.LogError("Rigidbody component is missing on " + gameObject.name);
        }
    }
    
    protected virtual void Update()
    {
        HandleMovement();
        HandleJump();
        ClampPosition();
    }
    // ABSTRACTION: Higher-level methods like HandleMovement, HandleJump, and TriggerGameOver
    private void HandleMovement()
    {
        _horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * (_horizontalInput * speed * Time.deltaTime));
    }
    
    private void HandleJump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
        }
    }

    // Animal cannot move out of fixed Boundaries
    private void ClampPosition()
    {
        _animalPosition = transform.position;
        _animalPosition.x = Mathf.Clamp(_animalPosition.x, boundaryLeft, boundaryRight);
        transform.position = _animalPosition;
    }

    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
            
        }
        if (other.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("Collission with" + other.gameObject.name);
            TriggerGameOver();
        }
    }
    
    public void TriggerGameOver()
    {
        // Freeze the game
        Time.timeScale = 0f;

        // Activate the Game Over UI
        if (gameOverPopup != null)
        {
            gameOverPopup.SetActive(true);
        }

        Debug.Log("Game Over triggered!");
    }
    
}

