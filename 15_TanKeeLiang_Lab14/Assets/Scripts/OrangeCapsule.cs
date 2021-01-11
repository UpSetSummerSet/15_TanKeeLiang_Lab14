using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OrangeCapsule : MonoBehaviour
{
    public GameObject OrangeText;
    int OrangeCounter;

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
        if (other.gameObject.tag == "Player")
        {
            OrangeCounter++;

            OrangeText.GetComponent<Text>().text = "Orange: " + OrangeCounter;

            audiosource.Play();
        }
    }
}
