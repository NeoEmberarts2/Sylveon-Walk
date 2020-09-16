using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
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

    //Movement
 if ( Input.GetKey(KeyCode.UpArrow) ) {
      transform.Translate(0, 0, 1 * Time.deltaTime); 
      animator.SetFloat("Speed", 1f);
 } else {
     animator.SetFloat("Speed", 0f);
 }




//Rotation
//  if ( Input.GetKey(KeyCode.DownArrow) )
  if ( Input.GetKey(KeyCode.RightArrow) ) {
    transform.Rotate(0, 1, 0);
  }
  if ( Input.GetKey(KeyCode.LeftArrow) ) {
    transform.Rotate(0, -1, 0);
  }
 // if ( Input.GetKey(KeyCode.LeftArrow) )
    //move left
}
}
