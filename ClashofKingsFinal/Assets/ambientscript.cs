using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

// THIS CODE WAS SOURCED FROM https://developer.vuforia.com/forum/faq/unity-how-can-i-play-audio-when-targets-get-detected
// IT'S STRAIGHT FROM VUFORIA! Needed this to ensure the ambient noise plays on detection since we're unable to edit the built-in scripts

public class ambientscript : MonoBehaviour,ITrackableEventHandler
{
    private TrackableBehaviour mTrackableBehaviour;
    public AudioSource audio;

    void Start()
    {
        mTrackableBehaviour = GetComponent<TrackableBehaviour>();
        if (mTrackableBehaviour)
        {
            mTrackableBehaviour.RegisterTrackableEventHandler(this);
        }
    }

    public void OnTrackableStateChanged(
                                    TrackableBehaviour.Status previousStatus,
                                    TrackableBehaviour.Status newStatus)
    {
        if (newStatus == TrackableBehaviour.Status.DETECTED ||
            newStatus == TrackableBehaviour.Status.TRACKED ||
            newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
        {
            // Play audio when target is found
            audio.Play();
        }
        else
        {
            // Stop audio when target is lost
            audio.Stop();
        }
    }
}
