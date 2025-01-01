using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Scriptable Objects/Actions/Attack Action")]
public class EnemyAttackAction : EnemyAction
{
    public override void StartState(EnemyStateController controller)
    {
        Debug.Log("Starting Attack State");
        controller.Animator.SetBool("isCaught", true);
    }

    public override void Act(EnemyStateController controller)
    {
        
    }

}
