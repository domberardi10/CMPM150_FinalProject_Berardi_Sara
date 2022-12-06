using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoconutCollision : MonoBehaviour
{

    public CoconutAudio cocoAudio;
    private float audioTimer;

    // Start is called before the first frame update
    void Start()
    {
        audioTimer = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (cocoAudio.isCollision){
            audioTimer += Time.deltaTime;
            if (audioTimer > 3.5f){
                cocoAudio.isCollision = false;
                cocoAudio.isPlaying = false;
                audioTimer = 0f;
            }
        }
    }

    private void OnParticleCollision(GameObject other){
        cocoAudio.isCollision = true;
    }
}
