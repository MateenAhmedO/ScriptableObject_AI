using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Scriptable Objects/Actions/Chase Action")]
public class EnemyChaseAction : EnemyAction
{

    public override void StartState(EnemyStateController controller)
    {
        Debug.Log("Starting Chase State");
    }

    public override void Act(EnemyStateController controller)
    {
        ChasePlayer(controller);
    }

    private void ChasePlayer(EnemyStateController controller)
    {
        // Move towards the player
        controller.Agent.SetDestination(controller.PlayerTransform.position);
    }

}
