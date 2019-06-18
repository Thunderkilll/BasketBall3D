using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
   
    public Ball ball; //make the ball public 
    public GameObject playerCamera; //get the rotation references so we can move the ball with the camera 
    // Start is called before the first frame update
    [Range(.7f,2f)]
    public float ballDistance =1f;
    public float ballThrowingForce = 500f;
    public  bool  holdingball = true;
    void Start()
    {
        //dissable the gravity 
        ball.GetComponent<Rigidbody>().useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (holdingball)
        {
             positionOfTheBall(); //initial position of the ball
            if (Input.GetMouseButton(0))
            {
                Debug.Log("mouse clicked ball is out of your hands");
                ball.ActivatePEffect();//activate particle system
                holdingball = false;
                ball.GetComponent<Rigidbody>().useGravity = true;
                //apply force on the ball + curve
                ball.GetComponent<Rigidbody>().AddForce(playerCamera.transform.forward * ballThrowingForce);
            }

        }

      
      
    }

    public void positionOfTheBall()
    {
        Vector3 offset = playerCamera.transform.forward *  ballDistance;
        ball.transform.position = playerCamera.transform.position + offset; //position of the ball = position of the camera in the  player
    }
}
