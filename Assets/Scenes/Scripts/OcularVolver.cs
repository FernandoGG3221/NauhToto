﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class OcularVolver : MonoBehaviour, ITrackableEventHandler
{

    public GameObject Repetir;
    public GameObject tarjeta;

    TrackableBehaviour mTrackableBehaviour;
    // Start is called before the first frame update
    void Start()
    {
        mTrackableBehaviour = GetComponent<TrackableBehaviour>();
        if (mTrackableBehaviour)
            mTrackableBehaviour.RegisterTrackableEventHandler(this);
    }

    public void OnTrackableStateChanged(TrackableBehaviour.Status previousStatus, TrackableBehaviour.Status newStatus)
    {
        if (newStatus == TrackableBehaviour.Status.DETECTED || newStatus == TrackableBehaviour.Status.TRACKED || newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
        {
            print("DETECTA"); //Se ejecuta cuando detecta al Target
            Repetir.SetActive(true);
            tarjeta.SetActive(false);
        }
        else if (previousStatus == TrackableBehaviour.Status.TRACKED && newStatus == TrackableBehaviour.Status.NO_POSE)
        {
            print("PIERDE"); //Se ejecuta cuando pierde al Target
            Repetir.SetActive(false);
            tarjeta.SetActive(true);
        }
        else
        {
            Repetir.SetActive(false);
            tarjeta.SetActive(true);
            print("COMIENZO"); //Se ejecuta cuando comienza la escena
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            if (Input.GetKeyUp(KeyCode.Escape))
            {
                //quit application on return button
                Application.Quit();
                return;
            }
        }
    }
}
