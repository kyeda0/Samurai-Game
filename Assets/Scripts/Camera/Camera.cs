using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField] private Vector3 _offset;
    [SerializeField] private float _smooth;
    [SerializeField] private Transform _target;

    private Transform _selfTransform;

    private void Awake(){
        _selfTransform = GetComponent<Transform>();
    }

    private void LateUpdate(){
        CameraMoveToPlayer();   
    }

    private void CameraMoveToPlayer(){
        if(_target!= null){
            Vector3 _deltaMove = _target.position;
            _deltaMove.y = _selfTransform.position.y;
            _selfTransform.position = Vector3.Lerp(_selfTransform.position + _offset,_deltaMove,_smooth);
        }
    }
}
