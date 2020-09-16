using UnityEngine;
using System.Collections;

public class Controler : MonoBehaviour
{
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("a")) {
           animator.SetFloat("Speed", 1f);
        }
        if (Input.GetKey("s")) {
          animator.SetFloat("Speed", 0.5f);
        }
        if (Input.GetKey("d")) {
          animator.SetFloat("Speed", 0f);
        }
    }
}
