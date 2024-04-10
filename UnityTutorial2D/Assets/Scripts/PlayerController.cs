using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float playerSpeed;
    
    private InputManager inputManager;
    private PlayerInput playerInput;
    private InputAction movementAction;
    private Vector2 moveDirection;
    private Rigidbody2D rb;

    void Awake()
    {
        inputManager = InputManager.instance;
        playerInput = GetComponent<PlayerInput>();

        movementAction = playerInput.actions["Movement"];

        rb = GetComponent<Rigidbody2D>();

        movementAction.performed += Move;

    }

    public void Move(InputAction.CallbackContext ctx)
    {
        if (!ctx.performed)
        {
            return;
        }
        
        
    }

    void Update() // 60x
    {
        moveDirection = movementAction.ReadValue<Vector2>();
    }

    void FixedUpdate() // 50x
    {
        rb.MovePosition(rb.position + moveDirection * (playerSpeed * Time.fixedDeltaTime));
    }

    void LateUpdate() // 60x
    {
        
    }
}
