using UnityEngine;

public class EnemyAttack : EnemyState
{
    public bool playerHitbox;
    public EnemyAttack(EnemyScript enemy, EnemyStateMachine esm) : base(enemy, esm)
    {
    }
    public override void Enter()
    {
        enemy.anim.SetBool("Attack", true);
    }
    public override void Update()
    {
        base.Update();
    }
    public override void Exit()
    {
        enemy.anim.SetBool("Attack", false);
    }
    public void PlayerHit()
    {
        if(playerHitbox == true)
        {
            esm.ChangeState(esm.enemyIdleState);
        }

    }

    public override void OnCollisionEnter(Collision collision)
    {
        Debug.Log("collided in runstate");

        if (collision.gameObject.tag == "Player")
        {
            //collision.GetComponent<SpriteRenderer>().color = new Color(1, 0, 0);
            playerHitbox = true;
            PlayerHit();
        }
        else
        {
            playerHitbox = false;
        }
    }
}
