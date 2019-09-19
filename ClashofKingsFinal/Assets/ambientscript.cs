using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ambientscript : MonoBehaviour
{

    public GameObject thing, MyObject;
    AudioSource audioData;


    // Start is called before the first frame update
    void Start()
    {
        //MySource.Stop();
        audioData = GetComponent<AudioSource>();

        thing.GetComponent<GameObject>();
        if (MyObject.activeSelf == true)
            audioData.Play();
        else
            audioData.Stop();


    }

    // Update is called once per frame
    void Update()
    {
        

    }
}
