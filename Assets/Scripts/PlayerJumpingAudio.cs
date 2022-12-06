using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJumpingAudio : MonoBehaviour
{

    private FMODUnity.StudioEventEmitter eventEmitterRef;
    //public PlayerMovingAudio walkAudio;
    public bool isJumping = false;
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
        if (isJumping){
            audioTimer += Time.deltaTime;
            if (audioTimer > 1f){
                isJumping = false;
                audioTimer = 0f;
            }
        }
        if (!isJumping && Input.GetKeyDown(KeyCode.Space)){
            isJumping = true;
            eventEmitterRef.Play();
        }
    }
}
