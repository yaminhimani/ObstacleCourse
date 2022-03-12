using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{

    //this method is used whenever we are dealing with collisions in unity
    private void OnCollisionEnter(Collision other) {


       if(other.gameObject.tag == "Player" ){
        
         GetComponent<MeshRenderer>().material.color = Color.red;
         gameObject.tag = "Hit";

       }
    }
}
