using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RapidFirePowerup : PowerUpBase
{
    TurretController turret;

    public void Start()
    {
        turret = FindObjectOfType<TurretController>();
    }


    protected override void PowerUp()
    {
        turret.FireCooldown = .1f;
        Debug.Log("" + turret.FireCooldown);
        StartCoroutine(powerDuration());
    }

    protected override void PowerDown()
    {
        turret.FireCooldown = 0.5f;
        Debug.Log("" + turret.FireCooldown);
    }


    private IEnumerator powerDuration()
    {
        yield return new WaitForSeconds(2);
        OnHit();
    }


}
