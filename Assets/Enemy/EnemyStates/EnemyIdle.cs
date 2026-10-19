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

        IsPlayerNear();
        
    }
    public void IsPlayerNear()
    {
        bool isPlayerNear;
        float distance = Vector3.Distance(enemy.player.transform.position, enemy.transform.position);
        
        if(distance <= 10)
        {
            isPlayerNear = true;
        }
        else
        {
            isPlayerNear = false;
        }

        if(isPlayerNear == true)
        {
            esm.ChangeState(esm.enemyWalkState);
        }
    }
}
