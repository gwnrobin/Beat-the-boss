using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(FrontViewPlayerCharacter))]
public class FrontViewUserControl : MonoBehaviour 
{
    //contoller
    private FrontViewPlayerCharacter character;
    private InputManager inputManager;

    private Vector3 move;
    private bool jump;

    private void Start()
    {
        inputManager = GetComponent<InputManager>();
        character = GetComponent<FrontViewPlayerCharacter>();
    }

    private void Update()
    {
        if (!jump)
        {
            jump = inputManager.Jump();
        }
    }

    private void FixedUpdate()
    {
        // read inputs
        float h = inputManager.XMov();
        bool crouch = inputManager.Ctrl();
        bool run = inputManager.Shift();

        move = h * Vector2.right;

        character.Move(move, crouch, jump);
        jump = false;
    }
}
