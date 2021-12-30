using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using Vuforia;

public class Audio : MonoBehaviour,
    ITrackableEventHandler
{
    private TrackableBehaviour mTrackableBehaviour;
    //Audios
    public AudioSource audio;
    public AudioClip clip;
    public Button btn { get { return GetComponent<Button>(); } }
    public AudioSource source { get { return GetComponent<AudioSource>(); } }

    public GameObject instrucciones;
    public GameObject btnRepetirAudio;
    public GameObject panelInstrucciones;
    public GameObject panelRepetir;
    public GameObject Repetir;

    // Start is called before the first frame update
    void Start()
    {
       
        mTrackableBehaviour = GetComponent<TrackableBehaviour>();
        if (mTrackableBehaviour)
        {
            mTrackableBehaviour.RegisterTrackableEventHandler(this);
            
        }
        gameObject.AddComponent<AudioSource>();
        
        btnRepetirAudio.SetActive(false);
        panelRepetir.SetActive(false);
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
            
            //Destroy(instrucciones, 0);
            btnRepetirAudio.SetActive(true);
            panelRepetir.SetActive(true);
            panelInstrucciones.SetActive(false);
            btn.onClick.AddListener(audio.Play);
            if (gameObject.GetComponent<AudioSource>())
            {
               
            }
        }
        else
        {
            // Stop audio when target is lost
            audio.Stop();

            //Destroy(Repetir, 0);
            btnRepetirAudio.SetActive(false);
            panelRepetir.SetActive(false);
            panelInstrucciones.SetActive(true);
        }
    }

    public void intentar(){
        //  source = GetComponent<AudioSource>();
        //btn.onClick.AddListener(source);

        //clipTarget = (AudioClip)Resources.Load(ss);
        // audio.clip = clipTarget;
        // audio.loop = false;
        // audio.playOnAwake = false;
        //audio = (AudioSource)gameObject.AddComponent<AudioSource>();
        //audio.Play();

        source.PlayOneShot(clip);
    }
    // Update is called once per frame
    void Update()
    {

    }

}