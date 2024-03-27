using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using static UnityEngine.GraphicsBuffer;

public class EnemyAIForWork : MonoBehaviour
{
    public Transform Target;
    private NavMeshAgent agent;
    public Transform patrolPoint;
    public float DISTANCEtOtARGET;
    private Animator animator;
    public Transform distraction;
    public bool ChasingDistraction;
    public GameObject FX;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        DISTANCEtOtARGET = Mathf.Abs(Vector3.Distance(Target.position, transform.position));
        
        if(ChasingDistraction)
        {
            animator.SetInteger("State", 2);
        }
        
        if (DISTANCEtOtARGET > 10f && ChasingDistraction == false)
        {
            animator.SetInteger("State", 0);
            
        }
        else if(DISTANCEtOtARGET < 10f && DISTANCEtOtARGET >2 && ChasingDistraction == false)
        {
            animator.SetInteger("State", 2);
            agent.SetDestination(Target.position);
        }

        else if (DISTANCEtOtARGET < 2 && ChasingDistraction == false)
        {
           
            animator.SetInteger("State", 3);
        }
       
        if(Input.GetKey(KeyCode.F))
        {
            ChasingDistraction = true;
            agent.SetDestination(distraction.position);
            FX.gameObject.SetActive(true);
        }

    }
    public void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.CompareTag("Distraction"))
        {
            ChasingDistraction = false;
            FX.gameObject.SetActive(false);
        }
    }
}
