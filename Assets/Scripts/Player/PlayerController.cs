using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    //Parámetros
    private CharacterController _characterController;
    private Animator _animator;

    //Inputs
    private InputAction _moveAction;

    void Awake()
    {
        _characterController = GetComponent<CharacterController>();
    }
    
    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
