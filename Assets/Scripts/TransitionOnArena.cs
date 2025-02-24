using Unity.VisualScripting;
using UnityEngine;

public class TransitionOnArena : MonoBehaviour
{
    private Animator _animator;
    [SerializeField] private Transform _camera;
    void Start()
    {
        _animator = transform.GetComponent<Animator>();
        _camera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Transform>().transform;
    }

    void Update()
    {
        Transition();
    }

    private void Transition()
    {
        if(Input.GetKeyUp(KeyCode.Q)){
            _animator.SetBool("Transition",true);
        }
    }

    public void Transition2(){
        _camera.transform.position = new Vector3(_camera.transform.position.x + 10f,_camera.transform.position.y,_camera.transform.position.z);
        _animator.SetBool("Transition",false);
    }
}
