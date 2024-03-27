using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirpodsScript : MonoBehaviour
{
    public Rigidbody body;
    public Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
        body = GetComponent<Rigidbody>();
        body.AddForce(cam.transform.forward * 100f, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
      
    }
    
}
