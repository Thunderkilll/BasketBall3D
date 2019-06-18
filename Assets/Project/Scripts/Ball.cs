using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    public GameObject particleEffect;
    // Start is called before the first frame update
    void Start()
    {
        particleEffect.SetActive(false);
    }

    // Update is called once per frame
   public void ActivatePEffect()
    {
        particleEffect.SetActive(true);
    }
}
