using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RapidFire : PowerupBase
{
    TurretController playerTurret;
    protected override void PowerUp()
    {
        playerTurret = FindObjectOfType<TurretController>();

        if (playerTurret.FireCooldown == 0.5f)
        {
            playerTurret.FireCooldown *= 0.5f;
        } 
    }

    protected override void PowerDown()
    {
        if (playerTurret.FireCooldown == 0.25f)
        {
            playerTurret.FireCooldown *= 2f;
        }
        Destroy(gameObject);
    }


}
