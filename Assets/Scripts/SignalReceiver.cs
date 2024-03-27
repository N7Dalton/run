using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SignalReceiver : MonoBehaviour
{
    // Start is called before the first frame update
    void OnStartWalking()
    {
        Debug.Log("Walking...");
    }
    void OnDoubleJump()
    {
        Debug.Log("double Jumped...");
    }
    void OnJump()
    {
        Debug.Log("Jumped..");
    }
    void OnStartWallrunning()
    {
        Debug.Log("Is wallrunning...");
    }
}
