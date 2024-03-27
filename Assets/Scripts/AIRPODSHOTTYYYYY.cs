using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class AIRPODSHOTTYYYYY : MonoBehaviour
{
    public GameObject AirpodR;
    public GameObject AirpodL;
    Vector3 BarrelHole;
    public Transform BarrelHoleTrans;
    public Animator Animator;
    public float bulletCount = 2;
    public GameObject explosion;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        BarrelHole = BarrelHoleTrans.position;
      
        if(Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
        if(Input.GetKeyDown(KeyCode.R)) 
        {
            StartCoroutine("Reload");
        }
    }
    private void Shoot()
    {
        Debug.Log("shottin");
        if(bulletCount == 2f)
        {
            Animator.Play("AIRPODSHOTTY 1");
            Instantiate(AirpodR, BarrelHole, Quaternion.identity);
            bulletCount--;
        }
   else if (bulletCount == 1f)
        {
            Animator.Play("AIRPODSHOTTY 1");
            Instantiate(AirpodL, BarrelHole, Quaternion.identity);
            bulletCount--;
        }

    }
    private IEnumerator Reload()
    {
        Debug.Log("relodin");
        Animator.Play("AIRPODSHOTTY");
        yield return new WaitForSeconds(2.10f);
        bulletCount = 2;
    }
    private void SpawnExplosion()
    {
        Instantiate(explosion, BarrelHole, Quaternion.identity);
    }
}
