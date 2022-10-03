using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UnitCollider : MonoBehaviour
{
    //public GameObject door, key;
    [SerializeField] GameObject particle;

    void OnTriggerEnter(Collider col)
    {

        //if (col.gameObject.name == "FPSController")
        //{
            Debug.Log("Collision!");

            /*var parti1 = GameObject.Instantiate(particle1);
            parti1.transform.position = new Vector3(door.transform.position.x, door.transform.position.y+5, door.transform.position.z-5);
            Destroy(door);*/

            var parti = GameObject.Instantiate(particle);
            parti.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            //Destroy(key);
        //}
    }
}
