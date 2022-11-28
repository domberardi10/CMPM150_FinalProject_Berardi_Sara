using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyboxExposure : MonoBehaviour
{
    public float skyboxTimer = 0f;
    public float exposure = 1f;

    // Update is called once per frame
    void Update()
    {
        skyboxTimer += Time.deltaTime;
        RenderSettings.skybox.SetFloat("_Exposure", exposure);
        if ((skyboxTimer > 22f) && (skyboxTimer < 30f)){
            if (exposure > .1f){
                exposure -= .0005f;
            }
        }
        else if ((skyboxTimer > 54f) && (skyboxTimer < 62f)){
            if (exposure < 1f){
                exposure += .0005f;
            }
        }
        else if (skyboxTimer > 70f){
            skyboxTimer = 0f;
        }

    }
}
