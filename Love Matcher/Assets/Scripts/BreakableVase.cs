using UnityEngine;

public class BreakableVase : MonoBehaviour
{
    public GameObject brokenVase; // Prefab for the broken vase

    void OnCollisionEnter2D(Collision2D coll)
    {
        // Check if the object that collided with the vase is tagged as "Player"
        if (coll.collider.name == "Hero")
        {
            // Instantiate the broken vase prefab at the same position and rotation as the vase
            Instantiate(brokenVase, transform.position, transform.rotation);

            // Destroy the vase game object
            Destroy(gameObject);
        }
    }
}