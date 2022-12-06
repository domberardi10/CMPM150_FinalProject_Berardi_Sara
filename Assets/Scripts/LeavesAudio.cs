using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeavesAudio : MonoBehaviour
{

    private FMODUnity.StudioEventEmitter eventEmitterRef;
    private float audioTimer;

    // Start is called before the first frame update
    void Start()
    {
        eventEmitterRef = GetComponent<FMODUnity.StudioEventEmitter>();
        audioTimer = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        audioTimer += Time.deltaTime;
        if (audioTimer > 10f){
            eventEmitterRef.Play();
            audioTimer = 0f;
        }
    }
}
