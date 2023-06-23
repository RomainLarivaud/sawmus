using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HospitalDoor : MonoBehaviour
{
    AudioSource audioS;
    bool closed = true;

    private void Start()
    {
        audioS = GetComponent<AudioSource>();
    }
    public void Open()
    {
        if (closed)
        {
            transform.Rotate(new Vector3(0, -200, 0));
            audioS.Play();
            closed = true;
        }
    }
}
