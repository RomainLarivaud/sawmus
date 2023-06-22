using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_PlayerStateHandler : MonoBehaviour
{
    public bool canMove = false;
    BNG.SmoothLocomotion smoothLocomotion;

    // Start is called before the first frame update
    void Start()
    {
        smoothLocomotion = GetComponent<BNG.SmoothLocomotion>();
        smoothLocomotion.UpdateMovement = canMove;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ToggleMovement()
    {
        canMove = !canMove;
        smoothLocomotion.UpdateMovement = canMove;
    }
}
