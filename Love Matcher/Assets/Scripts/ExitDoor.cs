using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitDoor : MonoBehaviour
{
    [SerializeField] GameObject text;
    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("Door");
        text.SetActive(true);
    }
}
