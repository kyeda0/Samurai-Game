using UnityEngine;

public class PlayerHealth : HealthAbstract
{
    private PlayerMovement _player;
    private AttackAbstract _allattackAbstract;
    private EnemyAttack _enemyAttack;
    private void Awake()
    {
        _player = GetComponent<PlayerMovement>();
        _allattackAbstract = GetComponent<AttackAbstract>();
        _enemyAttack  = GameObject.FindWithTag("Enemy").GetComponent<EnemyAttack>();
    }
    public override void TakeDamage(float _damage)
    {
        base.TakeDamage(_damage);
        Debug.Log("Игрок получил дамаг" + _damage);
    }
    public  override void Kill() 
    {
        _allattackAbstract._attackRange = 0f;
        _player._currentSpeed = 0f;
        _enemyAttack._attackRange = 0f;
        base.Kill();
    }
}
