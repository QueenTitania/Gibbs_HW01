using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charger : EnemyBase
{
    [SerializeField] GameObject rapidPower;

    protected override void OnHit()
    {
        MoveSpeed *= 2;
    }

    public override void Kill()
    {
        base.Kill();
        Instantiate(rapidPower, transform.position, transform.rotation);
    }

}
