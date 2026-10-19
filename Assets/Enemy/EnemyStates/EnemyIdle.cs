using UnityEngine;

public class EnemyIdle : EnemyState
{
    public float idleTimer = 0.1f;
    public EnemyIdle (EnemyScript enemy, EnemyStateMachine esm) : base(enemy, esm)
    {
    }

    public override void Enter()
    {
        base.Enter();
        Debug.Log("Enemy idle start");
    }
    public override void Exit()
    {
        Debug.Log("Enemy idle End");
        enemy.StopAllCoroutines();
    }


    public override void Update()
    {
        idleTimer -= Time.deltaTime;
        if(idleTimer <= 0)
        {
            esm.ChangeState(esm.enemyWalkState);
        }
        
    }
}
