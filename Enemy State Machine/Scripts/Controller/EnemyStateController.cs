    using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyStateController : MonoBehaviour
{
    public EnemyState CurrentState;
    public EnemyState RemainState;

    public LayerMask DetectLayer;
    public float DetectRadius;
    public float AttackRadius;
    public float LeaveRadius;

    public Transform PlayerTransform;
    public List<Transform> Waypoints;

    [HideInInspector] public NavMeshAgent Agent;
    [HideInInspector] public Animator Animator;
    [HideInInspector] public int NextWaypointIndex = 0;

    private bool _activateStatus;

    private void Awake()    
    {
        Agent = GetComponent<NavMeshAgent>();
        Animator = GetComponentInChildren<Animator>();
    }

    // Start is called before the first frame update
    void Start()
    {
        _activateStatus = true;
        CurrentState.EnterState(this);
    }

        // Update is called once per frame
    void Update()
    {
        if(!_activateStatus) 
            return;
        CurrentState.UpdateState(this);
    }


    private void OnDrawGizmos()
    {
        if(CurrentState != null)
        {
            Gizmos.color = CurrentState.SceneGizmosColor;
            Gizmos.DrawSphere(transform.position, 2f);
        }
    }

    public void TransitionToState(EnemyState nextState)
    {
        if(nextState != RemainState)
        {
            CurrentState = nextState;
            CurrentState.EnterState(this);
        }
    }
}
