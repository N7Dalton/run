using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyOthers : MonoBehaviour
{
    public string tagOfOther;
   
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag(tagOfOther))
        {
            Destroy(other.gameObject);
        }
    }
}
