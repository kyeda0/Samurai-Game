using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    private Transform _playerPosition;
    private NavMeshAgent _agent;
    private AttackAbstract _enemyAttack;
    void Start()
    {
        _playerPosition = GameObject.FindGameObjectWithTag("Player").transform;
        _agent = GetComponent<NavMeshAgent>();
        _enemyAttack = GetComponent<AttackAbstract>();
        _agent.stoppingDistance = _enemyAttack._attackRange - 0.5f;
    }

    void Update()
    {
        MoveToPlayer();
    }

    private void MoveToPlayer(){
        if(_playerPosition == null) return;

        float _distant = Vector3.Distance(transform.position,_playerPosition.position);

        if(_distant > _enemyAttack._attackRange){
            _agent.SetDestination(_playerPosition.position);
        }

        else{
            _agent.ResetPath();
            transform.LookAt(_playerPosition.position);
        }
    }
}
