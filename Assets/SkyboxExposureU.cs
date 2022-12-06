using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyboxExposureU : MonoBehaviour
{
    public float dayTimer;
    public float exposureChange;

    private float skyboxTimer = 0f;
    private float exposure = 1f;

    // Update is called once per frame
    void Update()
    {
        skyboxTimer += Time.deltaTime;
        RenderSettings.skybox.SetFloat("_Exposure", exposure);
        if ((skyboxTimer > 0f) && (skyboxTimer < dayTimer)){
            if (exposure > .1f){
                exposure -= exposureChange;
            }
        }
        else if ((skyboxTimer > dayTimer) && (skyboxTimer < (dayTimer * 2))){
            if (exposure < 1f){
                exposure += exposureChange;
            }
        }
        else if (skyboxTimer > (dayTimer * 2)){
            skyboxTimer = 0f;
        }

    }
}
