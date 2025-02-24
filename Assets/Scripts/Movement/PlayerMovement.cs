using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private  float _standartSpeed;
    private  float _currentSpeed;
    private float _inputHorizontal;
    private float _inputVertical;
    void Update()
    {
        Movement();
    }

    private void Movement()
    {
        _inputHorizontal = Input.GetAxis("Horizontal");
        _inputVertical = Input.GetAxis("Vertical");
        Vector3 _movement = (transform.forward * _inputVertical) + (transform.right * _inputHorizontal);
        Vector3 _changePostion = transform.position +_movement * _currentSpeed * Time.deltaTime;
        transform.position = _changePostion;  
        if(Input.GetKeyDown(KeyCode.LeftShift)){
            _currentSpeed += 5f;
        }
        else if (Input.GetKeyUp(KeyCode.LeftShift)){
            _currentSpeed = _standartSpeed;
        }
    }
}
