using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UnitCollider : MonoBehaviour
{

    [SerializeField] GameObject particle1, particle2;

    void OnCollisionEnter2D(Collision2D col)
    {

        if (col.gameObject.name == "Arrow(Clone)" && transform.gameObject.tag == "Unit")
        {
            transform.gameObject.tag = "Draggable";
            var parti1 = GameObject.Instantiate(particle1, this.transform);
        }
        else if (transform.gameObject.tag == "Dragging" && col.gameObject.tag == "Draggable")
        {
            transform.SetParent(col.gameObject.transform, true);
            this.gameObject.GetComponent<Npc>().SetFollow(col.gameObject);
            transform.gameObject.tag = "Untagged";

        }
            //Debug.Log("Collision!");

            var parti2 = GameObject.Instantiate(particle2);
            parti2.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            //Destroy();
        //}
    }
}
