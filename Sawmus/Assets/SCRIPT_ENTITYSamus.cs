using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCRIPT_ENTITYSamus : MonoBehaviour
{

    Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    // Start is called before the first frame update
    void Start()
    {
        animator.SetBool("chasing", true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
