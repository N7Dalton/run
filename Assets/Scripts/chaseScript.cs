using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using static UnityEngine.GraphicsBuffer;

public class chaseScript : MonoBehaviour
{
    public GameObject playercam;
    public Transform playerTransform;
    public NavMeshAgent agent;
    public Vector3 lookatAngle;
    // Start is called before the first frame update
    void Start()
    {
        playercam = GameObject.FindWithTag("MainCamera");
    }

    // Update is called once per frame
    void Update()
    {
        playerTransform = playercam.transform;
        agent.SetDestination(playerTransform.position);
        //transform.LookAt(playerTransform, lookatAngle);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Collider>().tag == "Bullet")
        {
            Debug.Log("kill enemy");
            Destroy(this.gameObject);
        }
    }
}
