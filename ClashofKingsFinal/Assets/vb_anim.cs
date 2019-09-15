using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class vb_anim : MonoBehaviour, IVirtualButtonEventHandler
{

    public GameObject tyrion, vButton;
    public AudioSource MySource;
    public AudioClip MyClip;

    // Start is called before the first frame update
    void Start()
    {
        vButton = GameObject.Find("VirtualButton");
        vButton.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        tyrion.GetComponent<GameObject>();
        
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        tyrion.SetActive(true);
        MySource.PlayOneShot(MyClip);
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        MySource.Stop();
        tyrion.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
