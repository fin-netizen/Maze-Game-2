using UnityEngine;

public class EnemyState : MonoBehaviour
{
    protected EnemyScript enemy;
    protected EnemyStateMachine esm;

    public EnemyState(EnemyScript enemy, EnemyStateMachine esm)
    {
        this.enemy = enemy;
        this.esm = esm;
    }

    public virtual void Enter()
    {

    }
    
    public virtual void Update()
    {
        
    }
    public virtual void FixedUpdate() { }
    public virtual void Exit() { }
}
