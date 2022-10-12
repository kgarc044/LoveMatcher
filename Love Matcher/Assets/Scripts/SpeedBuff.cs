using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Powerups/Buffs")]
public class SpeedBuff : PowerUpEffect
{
    public float amount;
    public override void Apply(GameObject target)
    {
        target.GetComponent<Cainos.PixelArtTopDown_Basic.TopDownCharacterController>().speed += amount;
        target.GetComponent<SpriteRenderer>().color = Color.yellow;
    }
}
