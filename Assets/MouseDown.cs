using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseDown : MonoBehaviour
{
 

    private void OnMouseDown()
    {
        this.GetComponent<Renderer>().material.color =  Color.red;
    }
   
}
