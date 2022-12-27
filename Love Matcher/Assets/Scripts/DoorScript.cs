using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    public SlingshotScript heroTotalKeys;
    public GameObject openDoor;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(heroTotalKeys.keyCounter == 3)
        {
            Instantiate(openDoor, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}
