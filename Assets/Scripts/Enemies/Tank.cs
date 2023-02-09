using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank : EnemyBase
{
    private IEnumerator halt;

    public void Start()
    {
        halt = PauseTank();
    }

    protected override void OnHit()
    {
        StopCoroutine(halt);
        StartCoroutine(halt);
        halt = PauseTank();
    }


    public IEnumerator PauseTank()
    {
        //Debug.Log("enter coroutine");
        MoveSpeed = 0;
        yield return new WaitForSeconds(1);
        MoveSpeed = 0.05f;
        //Debug.Log("" + MoveSpeed);
        //Debug.Log("exit coroutine");
    }

}
