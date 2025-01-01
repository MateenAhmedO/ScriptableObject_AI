using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class EnemyTransition
{
    public EnemyDecision _EnemyDecision;
    public EnemyState _TrueState;
    public EnemyState _FalseState;
}
