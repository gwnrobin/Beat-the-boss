﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
[RequireComponent(typeof(Animator))]
public class FrontViewPlayerCharacter : MonoBehaviour
{
    CharacterController charCtrl;
    Animator animator;

    [SerializeField] float speedMultiplier = 1f;
    [SerializeField] float jumpForce = 1f;
    [SerializeField] float gravity = 1f;
    [SerializeField] float animSpeedMultiplier = 1f;
    [SerializeField] float maxRunSpeed = 1f;

    private bool readyToJump = true;
    private bool isGrounded = true;
    private bool crouching = false;

    private Vector3 movement = Vector3.zero;

    const float jumpAbortSpeed = 10f;
    const float groundAcceleration = 20f;
    const float groundDeceleration = 30f;
    const float stickingGravityProportion = 0.3f;

    float speed;

    float turnAmount;
    float forwardAmount;

    void Start()
    {
        animator = GetComponent<Animator>();
        charCtrl = GetComponent<CharacterController>();
    }

    public void Move(Vector2 move, bool crouch, bool jump)
    {
        if (isGrounded)
        {
            HandleGroundedMovement(move, crouch, jump);
        }
        else
        {
            HandleAirborneMovement(jump);
        }

        charCtrl.Move(movement * Time.deltaTime);
        isGrounded = charCtrl.isGrounded;
    }

    void HandleGroundedMovement(Vector2 move, bool crouch, bool jump)
    {
        bool moving = move != Vector2.zero;

        movement = new Vector2(movement.x, movement.y)
        {
            x = move.x,
            y = -gravity * stickingGravityProportion
        };

        if (!jump)
        {
            readyToJump = true;
        }

        if (jump && readyToJump)
        {
            readyToJump = false;
            movement.y = jumpForce;
        }
    }

    void HandleAirborneMovement(bool jump)
    {
        if (!jump && movement.y > 0.0f)
        {
            movement.y -= jumpAbortSpeed * Time.deltaTime;
        }
        if (Mathf.Approximately(movement.y, 0f))
        {
            movement.y = 0f;
        }

        movement.y -= gravity * Time.deltaTime;
    }
}
