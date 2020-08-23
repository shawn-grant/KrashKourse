using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CamShaker : MonoBehaviour
{
    public bool shakeOnStart = false;
    CinemachineImpulseSource impulse;

    void Start()
    {
        impulse = GetComponent<CinemachineImpulseSource>();

        if (shakeOnStart)
            impulse.GenerateImpulse();
    }

    public void Shake()
    {
        impulse.GenerateImpulse();
    }
}
