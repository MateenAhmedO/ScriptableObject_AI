
using UnityEngine;


[CreateAssetMenu(menuName = "Scriptable Objects/Decisions/Look Decision")]
public class EnemyDetectDecision : EnemyDecision
{
    private Collider[] colliders;

    public override bool Decide(EnemyStateController controller)
    {
        bool targetVisible = Detect(controller);
        return targetVisible;
    }

    private bool Detect(EnemyStateController controller)
    {
        colliders = Physics.OverlapSphere(controller.transform.position, controller.DetectRadius, controller.DetectLayer);
        
        if (colliders.Length <= 0)
        {
            controller.PlayerTransform = null;
            return false;
        }

        controller.PlayerTransform = colliders[0].transform;
        return true;
    }
}
