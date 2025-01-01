using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Scriptable Objects/Decisions/Attack")]
public class EnemyAttackDecision : EnemyDecision
{
    public override bool Decide(EnemyStateController controller)
    {
        if(Vector3.Distance(controller.transform.position , controller.PlayerTransform.position) <= controller.AttackRadius)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
