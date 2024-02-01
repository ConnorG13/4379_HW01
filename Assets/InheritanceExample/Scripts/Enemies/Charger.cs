using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Charger : EnemyBase
{
    [SerializeField] private GameObject itemDrop;

    protected override void OnHit()
    {
        MoveSpeed *= 2;
    }

    public override void Kill()
    {

        Instantiate(itemDrop, gameObject.transform.position, gameObject.transform.rotation);
        base.Kill();
    }
}
