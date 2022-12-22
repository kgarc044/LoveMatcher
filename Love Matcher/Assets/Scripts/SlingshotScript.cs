using UnityEngine;

public class SlingshotScript : MonoBehaviour
{
    public float power = 10f;
    public Rigidbody2D rb;
    public int keyCounter = 0;

    public Vector2 minPower;
    public Vector2 maxPower;

    Camera cam;
    Vector2 force;
    Vector3 startingPoint;
    Vector3 endPoint;

    private void Start()
    {
        cam = Camera.main;
        transform.gameObject.tag = "Untagged";
    }

    private void Update()
    {
        if (transform.gameObject.tag == "Draggable")
        {
            if (Input.GetMouseButtonDown(0))
            {
                startingPoint = cam.ScreenToWorldPoint(Input.mousePosition);
                startingPoint.z = 15;
            }

            if (Input.GetMouseButtonUp(0))
            {
                endPoint = cam.ScreenToWorldPoint(Input.mousePosition);
                endPoint.z = 15;

                force = new Vector2(Mathf.Clamp(startingPoint.x - endPoint.x, minPower.x, maxPower.x), Mathf.Clamp(startingPoint.y - endPoint.y, minPower.y, maxPower.y));
                rb.AddForce(force * power, ForceMode2D.Impulse);
                transform.gameObject.tag = "Untagged";
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Key")
        {
            keyCounter++;
            Destroy(collision.gameObject);
        }
    }
    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //now your gameObject was clicked!
            transform.gameObject.tag = "Draggable";
        }
    }
}