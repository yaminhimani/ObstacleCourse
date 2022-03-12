using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{


int hits =0 ;
//keeps track of how many times our player hits the border
 private void OnCollisionEnter(Collision other) {

     
     if(other.gameObject.tag != "Hit"){
     hits++; 
     Debug.Log("You've bumped into a thing this many times: "+ hits);
     }
    
 }


}
