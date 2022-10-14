using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UnitCollider : MonoBehaviour
{
    public GameObject _canvas;

    private void Start()
    {
        _canvas = GameObject.Find("Canvas");
    }

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
            Npc dragging = this.gameObject.GetComponent<Npc>();
            Npc draggable = col.gameObject.GetComponent<Npc>();
            if (dragging.interest.name == draggable.interest.name)
            {
                transform.SetParent(col.gameObject.transform, true);
                dragging.SetFollow(col.gameObject);
                transform.gameObject.tag = "Untagged";
                _canvas.GetComponent<UI>().CoupleTotal = 1;
            }
        }
        //else if (transform.gameObject.tag == "Draggable" && col.gameObject.tag == "Dragging")
        //{

        //}
            //Debug.Log("Collision!");

        var parti2 = GameObject.Instantiate(particle2);
        parti2.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            //Destroy();
        //}
    }
}
