using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_EndDoorLock : MonoBehaviour
{
    public HospitalDoor doorToOpen;
    public GameObject sisterChain;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Plier")
        {
            if(sisterChain.gameObject == null)
            {
                doorToOpen.Open();
            }
            Destroy(this.gameObject);
        }
    }
}
