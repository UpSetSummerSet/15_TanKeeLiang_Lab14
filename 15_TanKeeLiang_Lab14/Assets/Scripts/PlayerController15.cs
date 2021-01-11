﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController15 : MonoBehaviour
{
    float speed = 5.0f;

    private AudioSource audiosource;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * -speed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.right * Time.deltaTime * -speed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Red"))
        {

        }
    }
}
