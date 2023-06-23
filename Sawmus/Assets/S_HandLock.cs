using System.Collections;
using System.Collections.Generic;
using BNG;
using UnityEngine;

public class S_HandLock : MonoBehaviour
{
    BoxCollider boxCollider;
    S_PlayerStateHandler playerStateHandler;
    AudioSource audioS;

    // Start is called before the first frame update
    void Start()
    {
        audioS = GetComponent<AudioSource>();
        boxCollider = GetComponent<BoxCollider>();
        playerStateHandler = GameObject.FindGameObjectWithTag("Player").GetComponent<S_PlayerStateHandler>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name);
        if (other.gameObject.tag == "Fork")
        {
            audioS.Play();
            playerStateHandler.vrEmulator.LeftControllerPosition = playerStateHandler.storedLeftHandPosition;
            playerStateHandler.ToggleMovement();
            Grabbable other_grabbable = other.gameObject.GetComponent<Grabbable>();
            other_grabbable.CanBeDropped = true;
            Destroy(transform.parent.gameObject);
        }
    }
}
