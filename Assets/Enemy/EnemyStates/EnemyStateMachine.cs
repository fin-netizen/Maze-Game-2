using Unity.IO.LowLevel.Unsafe;
using UnityEngine;

public class EnemyStateMachine 
{
    public EnemyState currentState, lastState;
    public EnemyIdle  enemyIdleState;
    public EnemyWalk enemyWalkState;
    public EnemyAttack enemyAttackState;
    
    public EnemyStateMachine(EnemyScript enemy)
    {
        enemyIdleState = new EnemyIdle(enemy, this);
        enemyWalkState = new EnemyWalk(enemy, this);
    }
    public void Init(EnemyState startingState)
    {
        currentState = startingState;
        lastState = null;
        startingState.Enter();
    }
    public void ChangeState(EnemyState newState)
    {
        currentState.Exit();
        lastState = currentState;
        currentState = newState;
        newState.Enter();
    }
    public void FixedUpdate()
    {
        currentState.FixedUpdate();
    }
    // Update is called once per frame
    public void Update()
    {
        currentState.Update();
    }
}
