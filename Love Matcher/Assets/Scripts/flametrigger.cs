using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flametrigger : MonoBehaviour
{
    Rigidbody2D rb;
    public GameObject particle;
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
            Debug.Log("Die");
            var parti = GameObject.Instantiate(particle, col.transform); 
            col.transform.position = new Vector2(0.15f, 6.05f);
        }
    }
}
