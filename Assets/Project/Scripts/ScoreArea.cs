using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreArea : MonoBehaviour
{

    public GameObject effectParticle;
    // Start is called before the first frame update
    void Start()
    {
        effectParticle.SetActive(false);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Ball")
        {
            Debug.Log("ball inside goal 2 points !!");
            effectParticle.SetActive(true); 
        }
    }
}
