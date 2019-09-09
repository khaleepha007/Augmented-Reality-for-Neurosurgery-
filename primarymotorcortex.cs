using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class primarymotorcortex : MonoBehaviour
{
    public GameObject character;
    Animator anim;
    bool isStrokingHand = false;

    void Start()
    {
        anim = character.GetComponent<Animator>();
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("primarymotorcortex"))
        {
            anim.SetTrigger("ifStroking");
            isStrokingHand = true;
            Debug.Log(" surgical instrument is colliding with primary motor cortex");
        }
    }
               
                
   
}


