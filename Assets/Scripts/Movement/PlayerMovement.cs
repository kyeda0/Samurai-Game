using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private  float _standartSpeed;
    private  float _currentSpeed;
    private float _inputHorizontal;
    private float _inputVertical;
    private Animator _animator;
    private Rigidbody _rb;

    private void Awake(){
        _currentSpeed = _standartSpeed;
        _animator = GetComponent<Animator>();
        _rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        Movement();
    }

    private void Movement()
    {
         _inputHorizontal = Input.GetAxis("Horizontal");
        _inputVertical = Input.GetAxis("Vertical");
       /* Vector3 _movement = (transform.forward * _inputVertical) + (transform.right * _inputHorizontal);
        Vector3 _changePostion = Vector3.ClampMagnitude(transform.position +_movement,1) * _currentSpeed * Time.deltaTime;
        transform.position = _changePostion;   */
        Vector3 _movement = new Vector3(_inputHorizontal,0,_inputVertical);
        if(_movement.magnitude > 0.1){
            transform.rotation = Quaternion.Lerp(transform.rotation,Quaternion.LookRotation(_movement),Time.deltaTime *5);
        }
        _animator.SetFloat("_currentSpeed",Vector3.ClampMagnitude(_movement,1).magnitude);
        _rb.velocity = Vector3.ClampMagnitude(_movement,1) * _currentSpeed;
        
        if(Input.GetKeyDown(KeyCode.LeftShift)){
            _currentSpeed += 5f;
        }
        else if (Input.GetKeyUp(KeyCode.LeftShift)){
            _currentSpeed = _standartSpeed;
        }
    }
}
