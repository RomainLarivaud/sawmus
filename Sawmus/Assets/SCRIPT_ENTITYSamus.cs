using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCRIPT_ENTITYSamus : MonoBehaviour
{

    Animator animator;
    public GameObject bowlContainer;
    public GameObject bowlPrefab;
    public HospitalDoor doorToOpen;
    public bool isChasing = false;
    public float moveSpeed = 6f;

    private void Awake()
    {
        animator = GetComponent<Animator>();
        bowlContainer = GameObject.Find("BowlContainer");
    }

    // Start is called before the first frame update
    void Start()
    {
    }


    public void DropBowl()
    {
        bowlContainer.SetActive(false);
        Instantiate(bowlPrefab, new Vector3(-2.638f, 2.08999991f, -4.63999987f), Quaternion.identity);
    }

    public void StartChase()
    {
        if (!isChasing)
        {
            isChasing = true;
            doorToOpen.Open();
            Debug.Log("chase started");
            animator.SetBool("chase", true);
        }
    }
}
