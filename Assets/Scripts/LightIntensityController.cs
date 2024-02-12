using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightIntensityController : MonoBehaviour
{
    [Range(0f, 1f)]
    public float intensity = 1f;
    public Light mainLight;
    public MeshRenderer bulbMeshRenderer;
    public MeshRenderer glassMeshRenderer;
    private Boolean animate;

    void Awake()
    {
        Animator animator = GetComponent<Animator>();

        if (animator != null && animator.enabled)
        {
            animate = true;

            bulbMeshRenderer.material = Instantiate(bulbMeshRenderer.material);
            glassMeshRenderer.material = Instantiate(glassMeshRenderer.material);
        }
    }

    void Update()
    {
        if (!animate)
        {
            return;
        }

        mainLight.intensity = intensity;

        bulbMeshRenderer.material.SetColor("_EmissionColor", Color.Lerp(new Color(0.5f, 0.5f, 0.5f), new Color(1, 1, 1), intensity));
        glassMeshRenderer.material.SetColor("_EmissionColor", Color.Lerp(new Color(0.04434f, 0.04434f, 0.04434f), new Color(0.17736f, 0.17736f, 0.17736f), intensity));
    }
}
