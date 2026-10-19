using UnityEngine;

public class EnemyWalk : EnemyState 
{
    Vector3 destinationPoint;
    public float range = 20f;
    public float inBetweenDistance = 10f;

    public EnemyWalk(EnemyScript enemy, EnemyStateMachine esm) : base(enemy, esm)
    {
    }
    public override void Enter()
    {
        enemy.anim.SetBool("Chase", true);
    }
    // Update is called once per frame
    public override  void Update()
    {
        MakeTargetPoint();
    }
    public override void Exit()
    {
        base.Exit();
        enemy.anim.SetBool("Chase", false);
    }
    void MakeTargetPoint()
    {
        //destinationPoint = enemy.player.transform.position;
        //float x, z;
        /*
        //make a random number between -3 and +3
        x = Random.Range(-range, range);

        //extend it by 2 metres
        if (x < 0)
        {
            x -= inBetweenDistance;
        }
        else
        {
            x += inBetweenDistance;
        }

        //Z
        z = Random.Range(-range, range);
        if (z < 0)
        {
            z -= inBetweenDistance;
        }
        else
        {
            z += inBetweenDistance;
        }
        
        destinationPoint.x = x;
        destinationPoint.z = z;
        destinationPoint.y = enemy.player.transform.position.y;
        */
        //debug gameobject to show where agent will eventually go

        enemy.agent.SetDestination(enemy.player.transform.position);
        Debug.Log("setting target to " + enemy.player.transform.position);




    }
}
