using UnityEngine;

[CreateAssetMenu(menuName = "Scriptable Objects/States/Enemy State")]
public class EnemyState : ScriptableObject
{
    public EnemyAction[] EnemyActions;
    public EnemyTransition[] EnemyTransitions;
    public Color SceneGizmosColor = Color.grey;

    public void EnterState(EnemyStateController controller)
    {
        for (int i = 0; i < EnemyActions.Length; i++)
        {
            EnemyActions[i].StartState(controller);
        }
    }

    public void UpdateState(EnemyStateController controller) 
    {
        DoActions(controller);
        CheckTransitions(controller);
    }

    private void DoActions(EnemyStateController controller)
    {
        for (int i = 0; i < EnemyActions.Length; i++)
        {
            EnemyActions[i].Act(controller);
        }
    }

    private void CheckTransitions(EnemyStateController stateController)
    {
        for (int i = 0; i < EnemyTransitions.Length; i++)
        {
            bool decisionToTransition = EnemyTransitions[i]._EnemyDecision.Decide(stateController);

            if(decisionToTransition)
                stateController.TransitionToState(EnemyTransitions[i]._TrueState);
            else
                stateController.TransitionToState(EnemyTransitions[i]._FalseState);

        }
    }
}
