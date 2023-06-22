using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCRIPT_ENTITYSamus : MonoBehaviour
{

    Animator animator;
    GameObject bowlContainer;
    public GameObject bowlPrefab;

    private void Awake()
    {
        animator = GetComponent<Animator>();
        bowlContainer = GameObject.Find("BowlContainer");
    }

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DropBowl()
    {
        bowlContainer.SetActive(false);
        Instantiate(bowlPrefab, new Vector3(-2.638f, 2.08999991f, -4.63999987f), Quaternion.identity);
    }
}
