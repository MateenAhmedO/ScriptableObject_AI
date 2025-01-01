using UnityEngine;

public abstract class EnemyAction : ScriptableObject
{
    public abstract void StartState(EnemyStateController controller);
    public abstract void Act(EnemyStateController controller);
}
