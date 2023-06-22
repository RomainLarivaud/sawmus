using System.Collections;
using System.Collections.Generic;
using BNG;
using UnityEngine;

public class S_PlayerStateHandler : MonoBehaviour
{
    public bool canMove = false;
    BNG.SmoothLocomotion smoothLocomotion;
    public VREmulator vrEmulator;
    public Vector3 storedLeftHandPosition;

    // Start is called before the first frame update
    void Start()
    {
        smoothLocomotion = GetComponent<BNG.SmoothLocomotion>();
        vrEmulator = GetComponentInParent<VREmulator>();
        smoothLocomotion.UpdateMovement = canMove;

        storedLeftHandPosition = vrEmulator.LeftControllerPosition;
        vrEmulator.LeftControllerPosition = new Vector3(-8.36999989f, -0.200000003f, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ToggleMovement()
    {
        canMove = !canMove;
        smoothLocomotion.UpdateMovement = canMove;
    }
}
