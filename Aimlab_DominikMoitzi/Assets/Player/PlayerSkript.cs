using System;
using System.Collections;
using System.Collections.Generic;
using System.Transactions;
using Unity.Properties;
using UnityEngine;

public class PlayerSkript : MonoBehaviour
{
    public float speed;
    public float jump = 1000;
    public float mouseXSpeed = 1;
    Rigidbody rigid;

    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float verticalinput = Input.GetAxis("Vertical");
        float horizontalinput = Input.GetAxis("Horizontal");

        float mouseXInput = Input.GetAxis("Mouse X");


        transform.position += transform.forward * verticalinput * speed;
        transform.position += transform.right * horizontalinput * speed;

        transform.Rotate (0, mouseXInput * mouseXSpeed, 0);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigid.AddForce(Vector3.up * jump);
        }

    }
}
