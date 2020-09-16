using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quit : MonoBehaviour
{
void OnMouseDown(){
    Application.Quit();
    Debug.Log("Quited");
}

    // Update is called once per frame
    void Update()
    {

    }
}
