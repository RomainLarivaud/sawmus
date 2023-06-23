using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HospitalDoor : MonoBehaviour
{

    public void Open()
    {
        transform.Rotate(new Vector3(0, -200, 0));
    }
}
