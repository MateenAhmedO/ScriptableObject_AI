using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Scriptable Objects/Decisions/Patrol Decision")]
public class EnemyPatrolDecision : EnemyDecision
{
    public override bool Decide(EnemyStateController controller)
    {
        bool targetVisible = CalculateDistanceFromPlayer(controller);
        return targetVisible;
    }

    private bool CalculateDistanceFromPlayer(EnemyStateController controller)
    {
        float distance = Vector3.Distance(controller.Agent.transform.position, controller.PlayerTransform.position);

        if (distance >= controller.LeaveRadius)
        {
            return true;
            controller.PlayerTransform = null;
        }
        else
        {
            return false;
        }
    }
}
