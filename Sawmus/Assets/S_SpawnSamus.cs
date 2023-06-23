using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_SpawnSamus : MonoBehaviour
{
    // Start is called before the first frame update
    public SCRIPT_ENTITYSamus samus;
    bool spawned = false;

    private void OnTriggerEnter(Collider other)
    {
        if (!spawned)
        {
            if(other.gameObject.tag == "Player")
            {
                Instantiate(samus, new Vector3(7.05465794f, 1.78801155f, -24.3062458f), Quaternion.identity);
                samus.GetComponent<Animator>().enabled = false;
                samus.bowlContainer.SetActive(false);
            }

        }
    }
}
