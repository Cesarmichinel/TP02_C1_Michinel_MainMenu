using UnityEngine;

public class MovementArrows : MonoBehaviour
{
    public float speed = 2f;
    public float rotationAngle = 5f;

    private SpriteRenderer SpriteRenderer;

    void Start()
    {
        SpriteRenderer = GetComponent<SpriteRenderer>();
    }


    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.down * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
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

        if (Input.GetKeyUp(KeyCode.F))
        {
            SpriteRenderer.color = new Color(Random.value, Random.value, Random.value);
        }
    }
}