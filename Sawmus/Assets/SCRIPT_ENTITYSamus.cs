using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCRIPT_ENTITYSamus : MonoBehaviour
{

    Animator animator;
    GameObject bowlContainer;
    Rigidbody body;
    public GameObject bowlPrefab;
    public HospitalDoor doorToOpen;
    bool isChasing = false;

    private void Awake()
    {
        animator = GetComponent<Animator>();
        body = GetComponent<Rigidbody>();
        bowlContainer = GameObject.Find("BowlContainer");
    }

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (isChasing)
        {
            body.MovePosition(new Vector3(7.11000013f, 0.899999976f, -24.5300007f));
        }
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
        }
    }
}
