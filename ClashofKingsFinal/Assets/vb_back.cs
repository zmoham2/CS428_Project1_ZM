using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class vb_back : MonoBehaviour, IVirtualButtonEventHandler
{

    public GameObject reviewButton, actualReviews, bookInfo, videoreview;
    

    // Start is called before the first frame update
    void Start()
    {
        reviewButton = GameObject.Find("VirtualButtonBack");
        reviewButton.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        actualReviews.GetComponent<GameObject>();
        bookInfo.GetComponent<GameObject>();
        videoreview.GetComponent<GameObject>();
        //actualReviews.SetActive(true);
       // bookInfo.SetActive(false);

    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        actualReviews.SetActive(true);
        bookInfo.SetActive(false);
        videoreview.SetActive(true);
        
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        actualReviews.SetActive(false);
        bookInfo.SetActive(true);
        videoreview.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {

    }
}
