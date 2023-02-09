using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public abstract class PowerUpBase : MonoBehaviour
{
    [SerializeField] protected float powerupDuration = 2f;

    protected abstract void PowerUp();

    protected abstract void PowerDown();

    protected virtual void OnHit()
    {
        gameObject.SetActive(false);
        PowerDown();
        Destroy(this);
    }

    private void OnTriggerEnter(Collider other)
    {
        Projectile projectile = other.GetComponent<Projectile>();
        PowerUp();
        //OnHit();
        
    }

}
