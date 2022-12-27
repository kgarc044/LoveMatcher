using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyScript : MonoBehaviour
{
    public SlingshotScript heroTotalKeys;

    private void Start()
    {
        heroTotalKeys = GameObject.FindGameObjectWithTag("Draggable").GetComponent<SlingshotScript>();
    }
    
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Key COllided");
        if (collision.gameObject.name == "Hero SlingShot")
        {
            Debug.Log("Key grabbed");
            heroTotalKeys.keyCounter++;
            Destroy(collision.gameObject);
        }
    }
}
