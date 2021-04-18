using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour
{
    public PlayerInput playerInput;
    public GameObject ship;
    private float forwardThrustPower = 10f;
    private float yawSpeed = 30f;
    private float pitchSpeed = 30f;
    Rigidbody rb;

    void Start()
    {
        rb = ship.GetComponent<Rigidbody>();
        playerInput.ForwardEvent += ForwardThrust;
        playerInput.YawEvent += YawMovement;
        playerInput.PitchEvent += PitchMovement;
    }

    public void ForwardThrust(float thrust)
    {
        ship.transform.Translate(ship.transform.forward * thrust * forwardThrustPower * Time.deltaTime, Space.World);
        //rb.AddForce(gameObject.transform.forward * thrust * forwardThrustPower * Time.deltaTime);
    }

    public void YawMovement(float yaw)
    {
        rb.AddTorque(ship.transform.up * yaw * yawSpeed * Time.deltaTime);
    }
    public void PitchMovement(float pitch)
    {
        rb.AddTorque(ship.transform.right * pitch * pitchSpeed * Time.deltaTime);
    }
}
