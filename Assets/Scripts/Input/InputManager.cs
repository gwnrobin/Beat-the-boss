using UnityEngine;

public class InputManager : MonoBehaviour
{
    bool prevJump;
    bool currJump;

    public float XMov()
    {
        return Input.GetAxisRaw(Strings.Movement.HORIZONTAL);
    }
    public bool Jump()
    {
        return Input.GetAxis(Strings.Movement.JUMP) != 0;
    }
    public bool Shift()
    {
        return Input.GetAxis(Strings.Movement.SHIFT) != 0;
    }
    public bool Ctrl()
    {
        return Input.GetAxis(Strings.Movement.CTRL) != 0;
    }
}
