using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class YellowCapsule : MonoBehaviour
{
    public GameObject YellowText;
    int YellowCounter;

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
            YellowCounter++;

            YellowText.GetComponent<Text>().text = "Yellow: " + YellowCounter;

            audiosource.Play();
        }
    }
}
