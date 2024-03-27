using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShakeTrigger : MonoBehaviour
{
   public AudioSource m_AudioSource;
    public void CAMSHAKE()
    {
        m_AudioSource.Play();
        Debug.Log("SHAKE");
        cameraShaker.Invoke();
    }
}
