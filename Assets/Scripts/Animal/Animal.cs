using UnityEngine;

public class Animal : MonoBehaviour
{
    [Header("Movement Settings")]
    public float speed = 5f;
    public float jumpForce = 5f;
    public float boundaryRight = 10f;
    public float boundaryLeft = -10f;

    private float _horizontalInput;
    private Vector3 _animalPosition;
    protected Rigidbody rb;

    // Initialisierung
    protected virtual void Start()
    {
        rb = GetComponent<Rigidbody>();
        if (rb == null)
        {
            Debug.LogError("Rigidbody component is missing on " + gameObject.name);
        }
    }

    // Hauptupdate-Methode
    protected virtual void Update()
    {
        HandleMovement();
        HandleJump();
        ClampPosition();
    }

    // Bewegung des Tieres
    private void HandleMovement()
    {
        _horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * (_horizontalInput * speed * Time.deltaTime));
    }

    // Sprung-Logik
    private void HandleJump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && rb != null)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }

    // Begrenzung der Position innerhalb der festgelegten Grenzen
    private void ClampPosition()
    {
        _animalPosition = transform.position;
        _animalPosition.x = Mathf.Clamp(_animalPosition.x, boundaryLeft, boundaryRight);
        transform.position = _animalPosition;
    }
}

