using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Scriptable Objects/Actions/Patrol Action")]
public class EnemyPatrolAction : EnemyAction
{
    public override void StartState(EnemyStateController controller)
    {
        Debug.Log("Starting Patrol State");
    }

    public override void Act(EnemyStateController controller)
    {
        Patrol(controller);
    }

    private void Patrol(EnemyStateController controller)
    {
        controller.Agent.SetDestination(controller.Waypoints[controller.NextWaypointIndex].position);

        if(Vector3.Distance(controller.transform.position , controller.Waypoints[controller.NextWaypointIndex].position) <= controller.Agent.stoppingDistance)
        {
            controller.NextWaypointIndex = (controller.NextWaypointIndex + 1) % controller.Waypoints.Count;
        }
    }

}
