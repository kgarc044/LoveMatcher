using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public PowerUpEffect powerUpeffect;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
        powerUpeffect.Apply(collision.gameObject);
    }
}
