using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{

  //these variables change our movement speed



  [SerializeField] float moveSpeed = 10f; //this is the speed we move the block 

  // Start is called before the first frame update
  //Method
  //This method runs only at the start of your game 
  void Start()
  {
    PrintInstructions();
  }

  // Update is called once per frame
  // runs throughout your game
  void Update()
  {
    movePlayer(); 
  }

  void movePlayer(){
    float xvalue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed; // this variable deals with moving our player left or right

    float zvalue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed; //this variable deals with moving our player up and down (on the z axsis)

    transform.Translate(xvalue, 0, zvalue);

  }


void PrintInstructions(){ 
  
  Debug.Log("Welcome to the game");
  Debug.Log("Move player with WASD or arrow keys"); //printing out a message
  Debug.Debug.Log("Don't hit the walls");
}




}
