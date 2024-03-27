using DG.Tweening;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraShaker : MonoBehaviour
{
    [SerializeField] private Transform cameraTransform;
    [SerializeField] private Vector3 PosStrength;
    [SerializeField] private Vector3 RotationStrength;
    public float duration;
    private static event Action Shake;

    public static void Invoke()
    {
        Shake?.Invoke();
    }

    private void OnEnable() => Shake += CameraShake;
    private void OnDisable() => Shake -= CameraShake;

    private void CameraShake()
    {
        cameraTransform.DOComplete();
        cameraTransform.DOShakePosition(duration, PosStrength);
        cameraTransform.DOShakeRotation(duration, RotationStrength);
    }
}
