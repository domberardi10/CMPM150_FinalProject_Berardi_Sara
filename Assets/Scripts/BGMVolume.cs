using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMVolume : MonoBehaviour
{
    // [SerializeField]
    // [FMODUnity.EventReference]
    // private string aSound;

    private FMODUnity.StudioEventEmitter eventEmitterRef;
    //private float startVol;
    private float volume;

    void Start()
    {
        eventEmitterRef = GetComponent<FMODUnity.StudioEventEmitter>();
        //startVol = volume;
    }

    void OnTriggerEnter(Collider other){
        if (other.CompareTag("Shark")){
            eventEmitterRef.SetParameter("Volume", 0f);
        }
    }

    void OnTriggerExit(Collider other){
        if (other.CompareTag("Shark")){
            eventEmitterRef.SetParameter("Volume", 1f);
        }
    }
}
