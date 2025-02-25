using UnityEngine;

public class HealthAbstract : MonoBehaviour,IHealth
{
    private float _currentHealth;
    [SerializeField] private float _maxHealth;

    public float CurrentHealth => _currentHealth;
    public float MaxHealth => _maxHealth;

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
