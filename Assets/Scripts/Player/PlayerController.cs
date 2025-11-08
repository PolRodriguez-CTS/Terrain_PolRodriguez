using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    //Componentes
    private CharacterController _characterController;
    private Animator _animator;

    //Inputs
    private InputAction _moveAction;
    public Vector2 _moveValue;

    //Camara
    [SerializeField] private Transform _mainCamera;
    private float _turnSmoothVelocity;
    private float _smoothTime = 0.2f;

    //Parámetros
    private float _playerSpeed = 5;

    void Awake()
    {
        _characterController = GetComponent<CharacterController>();
        _animator = GetComponentInChildren<Animator>();

        _moveAction = InputSystem.actions["Move"];
    }
    
    void Start()
    {
        
    }

    void Update()
    {
        _moveValue = _moveAction.ReadValue<Vector2>();
        Movement();
    }

    void Movement()
    {
        Vector3 direction = new Vector3(_moveValue.x, 0, _moveValue.y);

        _animator.SetFloat("Horizontal", _moveValue.x);
        _animator.SetFloat("Vertical", _moveValue.y);

        if (direction != Vector3.zero)
        {
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + _mainCamera.eulerAngles.y;
            float smoothAngle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref _turnSmoothVelocity, _smoothTime);
            transform.rotation = Quaternion.Euler(0, smoothAngle, 0);

            Vector3 moveDirection = Quaternion.Euler(0, targetAngle, 0) * Vector3.forward;

            _characterController.Move(moveDirection * _playerSpeed * Time.deltaTime);
        }
    }

    void Jump()
    {
        
    }

    void Gravity()
    {
        
    }
    
    bool IsGrounded()
    {
        return true;
    }
}
