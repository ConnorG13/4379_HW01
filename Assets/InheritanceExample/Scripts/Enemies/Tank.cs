using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Tank : EnemyBase
{
    bool alreadyStunned = false;
    protected override void OnHit()
    {
        if (alreadyStunned == false)
        {
            alreadyStunned = true;
            MoveSpeed = 0;
            Invoke("RestoreSpeed", 1);
        }

        if (alreadyStunned == true)
        {
            CancelInvoke("RestoreSpeed");
            Invoke("RestoreSpeed", 1);
        }
    }

    void RestoreSpeed()
    {
        MoveSpeed = 0.05f;
        alreadyStunned = false;
    }
}
