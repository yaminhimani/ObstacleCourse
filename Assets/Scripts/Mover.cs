using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{

   [SerializeField]  float xvalue = 0;
[SerializeField] float yvalue = 0.02f;
 [SerializeField]  float zvalue = 0;



  // Start is called before the first frame update
  //Method
  //This method runs only at the start of your game 
  void Start()
  {
  }

  // Update is called once per frame
  // runs throughout your game
  void Update()
  {
    transform.Translate(xvalue, yvalue, zvalue);

  }
}
