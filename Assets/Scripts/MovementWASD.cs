using UnityEngine;

public class MovementWASD : MonoBehaviour
{
    public float speed = 4f;
    public float rotationAngle = 8f;

    private SpriteRenderer SpriteRenderer;

    void Start()
    {
        SpriteRenderer = GetComponent<SpriteRenderer>();
    }


    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.down * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }


        if (Input.GetKeyDown(KeyCode.Q))
        {
            transform.Rotate(0f, 0f, rotationAngle);
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            transform.Rotate(0f, 0f, -rotationAngle);
        }

        if (Input.GetKeyUp(KeyCode.R))
        {
            SpriteRenderer.color = new Color(Random.value, Random.value, Random.value);
        }
    }
}


