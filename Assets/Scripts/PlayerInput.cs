using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public event EventManager.InputEventFloat ForwardEvent;
    public event EventManager.InputEventFloat YawEvent;
    public event EventManager.InputEventFloat PitchEvent;

    // Update is called once per frame
    void Update()
    {
        GetKeyboardInput();
    }

    void GetKeyboardInput()
    {
        if(ForwardEvent != null)
        {
            float verticalInput = Input.GetAxis("Throttle");
            if (verticalInput != 0)
            {
                ForwardEvent(verticalInput);
            }
        }
        if (YawEvent != null)
        {
            float horizontalInput = Input.GetAxis("Horizontal");
            if (horizontalInput != 0)
            {
                YawEvent(horizontalInput);
            }
        }
        if (PitchEvent != null)
        {
            float horizontalInput = Input.GetAxis("Vertical");
            if (horizontalInput != 0)
            {
                PitchEvent(horizontalInput);
            }
        }

    }
}
