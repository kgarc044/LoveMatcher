using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragObject : MonoBehaviour
{
    private Vector3 _dragOffset;
    private Camera _cam;
    private bool dragging = false;
    [SerializeField] private float _speed = 10;

    void Awake()
    {
        _cam = Camera.main;
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
        transform.gameObject.tag = "Draggable";
    }

    void OnMouseDrag()
    {
        //transform.position = GetMousePos() + _dragOffset;
        if (transform.gameObject.tag == "Dragging") transform.position = Vector3.MoveTowards(transform.position, GetMousePos() + _dragOffset, _speed * Time.deltaTime);
    }

    Vector3 GetMousePos()
    {
        var mousePos = _cam.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0;
        return mousePos;
    }

}
