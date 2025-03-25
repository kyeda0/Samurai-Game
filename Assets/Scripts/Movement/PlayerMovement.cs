using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] private   float _standartSpeed;
    [HideInInspector] public  float _currentSpeed;
    private float _inputHorizontal;
    private float _inputVertical;
    private void Awake(){
        _currentSpeed = _standartSpeed;
    }
    private void Update()
    {
        Movement();
    }

    private void Movement()
    {
        _inputHorizontal = Input.GetAxis("Horizontal");
        _inputVertical = Input.GetAxis("Vertical");
        Vector3 _movement = (transform.right * _inputHorizontal) + (transform.forward * _inputVertical);
        Vector3 _changePosition = transform.position +  _movement * _currentSpeed * Time.deltaTime;
        transform.position = _changePosition;
        if(Input.GetKeyDown(KeyCode.LeftShift)){
            _currentSpeed += 5f;
        }
        else if (Input.GetKeyUp(KeyCode.LeftShift)){
            _currentSpeed = _standartSpeed;
        }
    }
}
