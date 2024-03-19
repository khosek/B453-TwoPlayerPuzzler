using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Interactions;

public class PlayerController : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    public Vector2 moveInput;
    [SerializeField] int moveSpeed;

    public void FixedUpdate()
    {
        rb.velocity = moveInput.normalized * moveSpeed;
    }
    public void OnMoveInput(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>();
    }
}
