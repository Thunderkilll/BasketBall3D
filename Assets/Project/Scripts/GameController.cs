using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameController : MonoBehaviour
{

    public Player player;
    //timer to reset the scene
    public float resetTimer = 5f;
    Scene scene;
    // Start is called before the first frame update
    void Start()
    {
        scene = SceneManager.GetActiveScene();
    }

    // Update is called once per frame
    void Update()
    {
        if (player.holdingball == false)
        {
            //  Debug.Log("i'm not holding the ball");
            //we gonna wait for few secs and then restart game
            resetTimer -= Time.deltaTime;
           
            if (resetTimer <= 0)
            {
                Debug.Log("times out reset game ");
                resetTimer = 5f;
               SceneManager.LoadScene(scene.buildIndex); //reload this scene
            }
        }
    }
}
