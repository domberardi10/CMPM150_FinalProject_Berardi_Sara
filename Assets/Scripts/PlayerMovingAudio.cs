using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovingAudio : MonoBehaviour
{

    private FMODUnity.StudioEventEmitter eventEmitterRef;
    public PlayerJumpingAudio jumpAudio;
    public bool walkPlaying = false;

    // Start is called before the first frame update
    void Start()
    {
        eventEmitterRef = GetComponent<FMODUnity.StudioEventEmitter>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!jumpAudio.isJumping){
            if ((Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) 
                    || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D)) 
                    && !walkPlaying){
                    eventEmitterRef.Play();
                    walkPlaying = true;
            }
            else if (((!Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.A) 
                    && !Input.GetKey(KeyCode.S) && !Input.GetKey(KeyCode.D)) 
                    && walkPlaying)){
                    eventEmitterRef.Stop();
                    walkPlaying = false;
            }
        }
        else {
            if (walkPlaying){
                eventEmitterRef.Stop();
                walkPlaying = false;
            }
        }
    }
}
