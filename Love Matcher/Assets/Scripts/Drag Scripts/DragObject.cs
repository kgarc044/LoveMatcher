using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragObject : MonoBehaviour
{
    private Vector3 _dragOffset;
    private Camera _cam;
    private bool dragging = false;
    public float maxMoveSpeed = 10;
    public float smoothTime = 0.3f;
    public Vector2 currentVelocity = Vector2.zero;
    private Rigidbody2D rb;
    [SerializeField] private float _speed = 10;

    void Awake()
    {
        _cam = Camera.main;
        rb = transform.GetComponent<Rigidbody2D>();
    }

    void OnMouseDown()
    {
        if (transform.gameObject.tag == "Draggable")
        {
            _dragOffset = transform.position - GetMousePos();
            transform.gameObject.tag = "Dragging";
        }
    }

    void OnMouseUp()
    {
        if (transform.gameObject.tag == "Dragging") transform.gameObject.tag = "Draggable";
    }

    void OnMouseDrag()
    {
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = Vector2.SmoothDamp(transform.position, mousePosition, ref currentVelocity, smoothTime, maxMoveSpeed);
        rb.velocity = currentVelocity * 5;
    }

    Vector3 GetMousePos()
    {
        var mousePos = _cam.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0;
        return mousePos;
    }

}
