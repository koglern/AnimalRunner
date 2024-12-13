using UnityEngine;

public class Ground : MonoBehaviour
{
    public float speed;
    public GameObject otherGround; //reference to the other ground
    private Renderer background;
    private float backgroundWidth;

    void Start()
    {
        background = GetComponent<Renderer>();
        backgroundWidth = background.bounds.size.z; 
    }

    void Update()
    {
        // Move Ground to the back
        transform.Translate(new Vector3(0, 0, -1) * (speed * Time.deltaTime));

        // move ground, if it scrolls behind camera
        if (transform.position.z < -backgroundWidth)
        {
            Reposition();
        }
    }

    void Reposition()
    {
        // set current ground before the other one
        transform.position = new Vector3(
            transform.position.x,
            transform.position.y,
            otherGround.transform.position.z + backgroundWidth
        );
    }
}