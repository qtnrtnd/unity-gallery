using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointLightIntensityController : MonoBehaviour
{
    public LightIntensityController lightIntensityController; 

    void Update()
    {
        GetComponent<Light>().intensity = lightIntensityController.intensity;
    }
}
