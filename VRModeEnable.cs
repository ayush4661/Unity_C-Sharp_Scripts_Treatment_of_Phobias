using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VR;

public class VRModeEnable : MonoBehaviour
{
    // Start is called before the first frame update
    public void Start()
    {
        StartCoroutine(ActivatorVR("cardboard"));
    }

   public IEnumerator ActivatorVR(string VRENABLE)
    {
        UnityEngine.XR.XRSettings.LoadDeviceByName(VRENABLE);
        yield return null;
        UnityEngine.XR.XRSettings.enabled = true;
    }
   
}
