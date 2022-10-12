using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Npc : MonoBehaviour
{
    public Sprite[] interests;
    public GameObject interestSprite;
    public GameObject npc;
    private Rigidbody2D rb;
    private Vector3 movementDirection = new Vector3(1, 0, 0);
    private bool moving = false;
    // Start is called before the first frame update
    void Start()
    {
        rb = npc.GetComponent<Rigidbody2D>();
        interestSprite.GetComponent<SpriteRenderer>().sprite = interests[Random.Range(0,2)];
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.velocity = movementDirection;
        SpriteCheck();
        if (moving == false)
        {
            StartCoroutine("move"); // this is created so that npcs can have other things than just movement
        }
    }

    private IEnumerator move()
    {
        moving = true;
        newDirection();
        yield return new WaitForSeconds(Random.Range(2, 5));
        moving = false;
    }

    private void newDirection()
    {
        movementDirection = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), 0);
    }

    private void SpriteCheck()
    {
        if (movementDirection.x > 0)
        {
            npc.GetComponent<SpriteRenderer>().flipX = true;
        }
        else
        {
            npc.GetComponent<SpriteRenderer>().flipX = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Collider2D collider = collision.collider;

        Vector3 contactPoint = collision.contacts[0].point;
        Vector3 center = collider.bounds.center;

        if(contactPoint.x > center.x)
        {
            Debug.Log("side");
            movementDirection.x = movementDirection.x * -1;
        }
        else
        {
            Debug.Log("top/bottom");
            movementDirection.y = movementDirection.y * -1;
        }
    }
}
