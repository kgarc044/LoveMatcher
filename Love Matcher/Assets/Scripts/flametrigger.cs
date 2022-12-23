using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flametrigger : MonoBehaviour
{
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        //player hit
        if (col.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
        if (col.gameObject.tag == "Draggable" || col.gameObject.tag == "Dragging")
        {
            //die code
        }
    }
}
