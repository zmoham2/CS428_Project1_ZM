using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class virtualButton : MonoBehaviour, IVirtualButtonEventHandler
{
    public GameObject firstPanel, tyrion;
    public AudioSource MySource;
    public AudioClip MyClip;

    // Start is called before the first frame update
    void Start()
    {
        firstPanel = GameObject.Find("VirtualButton");
        firstPanel.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        tyrion.SetActive(true);    

    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        tyrion.SetActive(false);

    }

    

}
