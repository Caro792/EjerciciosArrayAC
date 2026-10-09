using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class ControlVignette : MonoBehaviour
{
  
    public PostProcessVolume volume; 
    private Vignette vignette;

    void Start()
    {
        
        
            volume.profile.TryGetSettings(out vignette);
        
    }

    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            CambiarIntensidadVignette(0.1f); 
        }
        
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            CambiarIntensidadVignette(0.3f);
        }
        
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            CambiarIntensidadVignette(0.65f);
        }
        
        if (Input.GetKeyDown(KeyCode.Alpha4)) 
        {
            CambiarIntensidadVignette(1f);
        }
    }

    public void CambiarIntensidadVignette(float nuevaIntensidad)
    {
        if (vignette != null)
        {
            vignette.intensity.overrideState = true;
            vignette.intensity.value = nuevaIntensidad;
        }
    }
}