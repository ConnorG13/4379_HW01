using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PowerupBase : MonoBehaviour
{
    [SerializeField] protected float PowerupDuration;
    private Collider myCollider;

    private void Start()
    {
        myCollider = GetComponent<Collider>();
    }

    protected abstract void PowerUp();

    protected abstract void PowerDown();

    private void OnTriggerEnter(Collider other)
    {
        Projectile projectile = other.GetComponent<Projectile>();
        if (projectile != null)
        {
            gameObject.transform.GetChild(0).gameObject.SetActive(false);
            myCollider.enabled = !myCollider.enabled;
            PowerUp();
            Invoke("PowerDown", PowerupDuration);
        }
    }

}
