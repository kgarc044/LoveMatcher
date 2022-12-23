using UnityEngine;

public class BreakableVase : MonoBehaviour
{
    public GameObject brokenVase;
    public GameObject keyFrag;// Prefab for the broken vase

    public bool spawnKey = false;

    void OnCollisionEnter2D(Collision2D coll)
    {
        // Check if the object that collided with the vase is tagged as "Player"
        if (coll.collider.name == "Hero SlingShot")
        {
            // Instantiate the broken vase prefab at the same position and rotation as the vase
            Instantiate(brokenVase, transform.position, transform.rotation);
            if (spawnKey == true)
            {
                Instantiate(keyFrag, transform.position, Quaternion.identity);
            }
            // Destroy the vase game object
            Destroy(gameObject);
        }
    }
}