using UnityEngine;

public class EnemyHealth : HealthAbstract
{

    public override void Kill() { base.Kill();}
    public override void TakeDamage(float _damage)
    {
        base.TakeDamage(_damage);
        Debug.Log("Враг получил дамаг" + _currentHealth);

    }
}
