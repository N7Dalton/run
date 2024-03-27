using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    public AudioSource steamSound;
    public Animator animator;
    public string nameOfAnim;
    public TextMeshProUGUI text;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        text.gameObject.SetActive(true);
       
    }
    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKey(KeyCode.E))
        {
            Debug.Log("pressed e");
            animator.Play(nameOfAnim);
            
        }
    }
    private void OnTriggerExit(Collider other)
    {
        text.gameObject.SetActive(false);

    }
}