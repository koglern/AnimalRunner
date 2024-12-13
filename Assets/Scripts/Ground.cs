using UnityEngine;

public class Ground : MonoBehaviour
{
    public float speed;
    public GameObject otherGround; // Referenz auf den anderen Boden
    private Renderer background;
    private float backgroundWidth;

    void Start()
    {
        background = GetComponent<Renderer>();
        backgroundWidth = background.bounds.size.z; // Z-Länge des Bodens
    }

    void Update()
    {
        // Bewegt den Boden kontinuierlich nach hinten
        transform.Translate(new Vector3(0, 0, -1) * (speed * Time.deltaTime));

        // Wenn der aktuelle Boden hinter die Kamera scrollt, wird er versetzt
        if (transform.position.z < -backgroundWidth)
        {
            Reposition();
        }
    }

    void Reposition()
    {
        // Setzt den aktuellen Boden vor den anderen Boden
        transform.position = new Vector3(
            transform.position.x,
            transform.position.y,
            otherGround.transform.position.z + backgroundWidth
        );
    }
}