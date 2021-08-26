using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VR;

public class VRModeDisable : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DeActivatorVR("none"));
    }
    public IEnumerator DeActivatorVR(string VRDISABLE)
    {
        UnityEngine.XR.XRSettings.LoadDeviceByName(VRDISABLE);
        yield return null;
        UnityEngine.XR.XRSettings.enabled = false;
    }


}
