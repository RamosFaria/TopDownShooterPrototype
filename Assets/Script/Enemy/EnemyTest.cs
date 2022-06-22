using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTest : Enemy
{
    private void Update()
    {
        MovementPattern();
    }


    public override void MovementPattern()
    {
        agent.SetDestination(Character.Instance.transform.position);
    }
}
