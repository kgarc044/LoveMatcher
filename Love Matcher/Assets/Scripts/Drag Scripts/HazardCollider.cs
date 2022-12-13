using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HazardCollider : MonoBehaviour
{

    //private GameObject child;
    void OnCollisionEnter2D(Collision2D col)
    {
        
        if (col.gameObject.name == "Npc" || col.gameObject.name == "Npc 2")
        {

            if(col.transform.gameObject.tag == "Draggable" || col.transform.gameObject.tag == "Dragging")
            {

                //child = col.transform.GetChild(1);
                if (col.transform.Find("Npc"))
                {
                    Transform heartbreak = col.transform.Find("Npc");
                    heartbreak.parent = null;
                    Npc child = heartbreak.gameObject.GetComponent<Npc>();
                    child.SetUnFollow();
                    heartbreak.gameObject.tag = "Draggable";
                }
                else if(col.transform.Find("Npc 2"))
                {
                    Transform heartbreak = col.transform.Find("Npc 2");
                    heartbreak.parent = null;
                    Npc child = heartbreak.gameObject.GetComponent<Npc>();
                    child.SetUnFollow();
                    heartbreak.gameObject.tag = "Draggable";
                }
            }
        }
    }
}
