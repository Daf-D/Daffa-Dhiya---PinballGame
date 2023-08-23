using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VFXManager : MonoBehaviour
{
    public GameObject vfxAudioSource;
    public GameObject vfxSwitchAudioSource;

    // Start is called before the first frame update
    public void PlayVFX(Vector3 spamPosition)
    {
        GameObject.Instantiate(vfxAudioSource, spamPosition, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
