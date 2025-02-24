using TMPro;
using UnityEngine;

public class HealthAbstract : MonoBehaviour,IHealth
{
    public float _currentHealth;
    public float _maxHealth;

    private void Awake()
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
        Destroy(gameObject);
    }
}
