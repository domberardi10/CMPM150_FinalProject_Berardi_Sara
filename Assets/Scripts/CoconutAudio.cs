using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoconutAudio : MonoBehaviour
{

    private FMODUnity.StudioEventEmitter eventEmitterRef;
    public bool isCollision;
    public bool isPlaying;

    // Start is called before the first frame update
    void Start()
    {
        isCollision = false;
        isPlaying = false;
        eventEmitterRef = GetComponent<FMODUnity.StudioEventEmitter>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isCollision && !isPlaying){
            isPlaying = true;
            eventEmitterRef.Play();
        }
    }
}
