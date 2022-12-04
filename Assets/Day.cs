using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Day : MonoBehaviour
{

    private Light dLight;
    private Light sLight;
    private Light pLight;
    private float dMax;
    private float sMax;
    private float pMax;
    public float dayTime;
    private float dayTimer = 0f;
    private bool goingNight = false;
    private bool goingDay = false;

    // Start is called before the first frame update
    void Start()
    {
        dLight = GameObject.Find("Directional Light").GetComponent<Light>();
        sLight = GameObject.Find("Spot Light").GetComponent<Light>();
        pLight = GameObject.Find("Point Light").GetComponent<Light>();
        dMax = dLight.intensity;
        sMax = sLight.intensity;
        pMax = pLight.intensity;
    }

    // Update is called once per frame
    void Update()
    {   
        if (dayTimer >= dayTime)
        {
            dayTimer = dayTime;
            goingDay = true;
            goingNight = false;
            dLight.intensity = 0f;
            pLight.intensity = pMax;
            sLight.intensity = sMax;
        }
        if (dayTimer <= 0f)
        {
            dayTimer = 0f;
            goingNight = true;
            goingDay = false;
            dLight.intensity = dMax;
            pLight.intensity = 0f;
            sLight.intensity = 0f;
        }

        if (goingDay)
        {
            dayTimer -= Time.deltaTime;
            dLight.intensity += dMax / dayTime * Time.deltaTime;
            pLight.intensity -= pMax / dayTime * Time.deltaTime;
            sLight.intensity -= sMax / dayTime * Time.deltaTime;
        }
        if (goingNight)
        {
            dayTimer += Time.deltaTime;
            dLight.intensity -= dMax / dayTime * Time.deltaTime;
            pLight.intensity += pMax / dayTime * Time.deltaTime;
            sLight.intensity += sMax / dayTime * Time.deltaTime;
        }
    }
}
