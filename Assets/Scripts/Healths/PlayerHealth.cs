using UnityEngine;

public class PlayerHealth : HealthAbstract
{

    public  override void Kill() { base.Kill(); }
    public override void TakeDamage(float _damage)
    {
        base.TakeDamage(_damage);
        Debug.Log("Игрок получил дамаг" + CurrentHealth);
    }
}
