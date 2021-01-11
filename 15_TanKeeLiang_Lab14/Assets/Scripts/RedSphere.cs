using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RedSphere : MonoBehaviour
{
    public GameObject RedText;
    int RedCounter;

    private AudioSource audiosource;
    // Start is called before the first frame update
    void Start()
    {
        audiosource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            RedCounter++;

            RedText.GetComponent<Text>().text = "Red: " + RedCounter;

            audiosource.Play();
        }
    }
}
