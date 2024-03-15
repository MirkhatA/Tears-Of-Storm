using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputReader : MonoBehaviour
{
    private PlayerInput _playerInput;

    [SerializeField] private Player _player;

    private void Awake()
    {
        _playerInput = new PlayerInput();

        _playerInput.Player.Movement.performed += OnMovement;
        _playerInput.Player.Movement.canceled += OnMovement;
    }

    private void OnEnable()
    {
        _playerInput.Enable();
    }

    private void OnMovement(InputAction.CallbackContext context)
    {
        Vector2 direction = context.ReadValue<Vector2>();
        _player.SetDirection(direction);
    }
}
