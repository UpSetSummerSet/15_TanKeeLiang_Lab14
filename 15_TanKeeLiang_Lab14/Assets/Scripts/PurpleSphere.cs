using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PurpleSphere : MonoBehaviour
{
    public GameObject PurpleText;
    int PurpleCounter;

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
            PurpleCounter++;

            PurpleText.GetComponent<Text>().text = "Purple: " + PurpleCounter;

            audiosource.Play();
        }
    }
}
