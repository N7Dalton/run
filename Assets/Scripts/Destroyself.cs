using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyself : MonoBehaviour
{
    public float WaitTime;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("SelfDestruct");
    }

    // Update is called once per frame
    void Update()
    {

    }
    public IEnumerator SelfDestruct()
        {
        yield return new WaitForSeconds(WaitTime);
        Debug.Log("commiting suicide");
            Destroy(this.gameObject);
        
        }
}
