using UnityEngine;
using UnityEngine.UI;
public class HealthsText : MonoBehaviour
{
    [SerializeField] private HealthAbstract _healtPlayer;
    private Image _health;
    void Start()
    {
        _health = GetComponent<Image>();
        _healtPlayer = GameObject.FindGameObjectWithTag("Player").GetComponent<HealthAbstract>();
    }

    void Update()
    {
        _health.fillAmount = _healtPlayer.CurrentHealth / _healtPlayer.MaxHealth;
    }
}
