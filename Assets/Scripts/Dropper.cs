using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{


 MeshRenderer renderer; //represents our meshrenderer
 Rigidbody rigidBody;
[SerializeField] float timeToWait = 5f;

//SerializeField allows us to modify our varibale from unity 

    // Start is called before the first frame update
    void Start()
    {

    renderer = GetComponent<MeshRenderer>();
    rigidBody = GetComponent<Rigidbody>();
    renderer.enabled = false; 
    rigidBody.useGravity = false;

    }

    // Update is called once per frame
    void Update()
    {
       // Debug.Log(Time.time);
    if(Time.time > timeToWait){

        Debug.Log("5 seconds have gone by ");
        renderer.enabled =  true;
        rigidBody.useGravity = true;


    }




    }
}
