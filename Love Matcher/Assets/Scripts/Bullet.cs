using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;

    [SerializeField]
    private Rigidbody2D bulletRB;

    void Start()
    {
        this.GetComponent<Rigidbody2D>().gravityScale = 0;
        bulletRB.velocity = transform.right * speed;
    }
}