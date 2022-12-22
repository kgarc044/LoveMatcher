using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NoDragField : MonoBehaviour
{

    [SerializeField] GameObject particle;

    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("Collision");
        if (col.gameObject.name == "Hero")
        {
            Debug.Log("Hero");
            if (col.transform.gameObject.tag == "Draggable" || col.transform.gameObject.tag == "Dragging")
            {
                col.transform.gameObject.tag = "Untagged";
                Debug.Log("Untagged");
            }
        }
    }

    void OnTriggerStay2D(Collider2D col)
    {
        Debug.Log("Inside");

        if (col.gameObject.TryGetComponent(out Rigidbody2D body))
        {
            //if (body.velocity == new Vector2(0, 0))
            if (body.velocity.x < .2 && body.velocity.y < .2 && col.gameObject.name != "PF Player")
            {
                Debug.Log("Stopped");
                //Vector2 stopSpot = col.transform.position;
                //var parti = GameObject.Instantiate(particle, new GameObject.transform.position() = stopSpot);
                var parti = GameObject.Instantiate(particle, col.transform); // create player die function
                col.transform.position = new Vector2(0.15f, 6.05f); 
            }
        }
    }

    void OnTriggerExit2D(Collider2D col) {
        Debug.Log("Left");
        if (col.gameObject.name == "Hero")
        {
            Debug.Log("Hero");
            if (col.transform.gameObject.tag == "Untagged")
            {
                col.transform.gameObject.tag = "Draggable";
                Debug.Log("Retagged");
            }
        }
    }
}
