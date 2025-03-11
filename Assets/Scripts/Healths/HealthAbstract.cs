using System.Collections;
using UnityEngine;

public class HealthAbstract : MonoBehaviour,IHealth
{
    [SerializeField] private float _currentHealth;
    [SerializeField] private float _maxHealth;
    [SerializeField] private float _timer;
    public float CurrentHealth => _currentHealth;
    public float MaxHealth => _maxHealth;

    private void Start()
    {
        _currentHealth = _maxHealth;
    }
    public virtual void TakeDamage(float _damage) 
    {
        _currentHealth -= _damage;

        if (_currentHealth <= 0)
        {
            Kill();
        }
    }

    public virtual void Kill()
    {
        StartCoroutine(ITimeForDead());
    }

    IEnumerator  ITimeForDead()
    {
        while(true){
            yield return new WaitForSeconds(_timer);
            Destroy(gameObject);
        }
    }
}
