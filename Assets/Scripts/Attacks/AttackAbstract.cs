using Unity.VisualScripting;
using UnityEngine;

public abstract class AttackAbstract : MonoBehaviour, IAttack
{
   [SerializeField] protected Transform _attackPosition;
   [SerializeField] protected LayerMask _targetMask;
   public float _attackRange;
   [SerializeField] protected float _attackDamage;
   [SerializeField] private  float _nextAttackTime;
   [SerializeField] protected float _attackRate;
   public virtual void Attack()
   {
      Collider[] _hitEnemies = Physics.OverlapSphere(_attackPosition.position,_attackRange,_targetMask);
      foreach (Collider _target in _hitEnemies)
      {
         _target.GetComponent<HealthAbstract>().TakeDamage(_attackDamage);
      }
   }

   public virtual void ResetAttack()
   {
      if(Time.time >= _nextAttackTime ){

         Attack();
         _nextAttackTime = Time.time + _attackRate;
      }
   }

    private  void OnDrawGizmosSelected()
      {
         if (_attackPosition == null)
            return;

         Gizmos.color = Color.blue;
         Gizmos.DrawWireSphere(_attackPosition.position, _attackRange);
      }

}
