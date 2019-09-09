using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class brainrotation : MonoBehaviour
{
   // public float x_speed = 3f;
    public float Y_speed = 3f;
   // public float Z_speed = 3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, Y_speed, 0);
    }
}
