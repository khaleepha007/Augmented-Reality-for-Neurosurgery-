using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pintoposition : MonoBehaviour
{
    Rigidbody m_Rigidbody;
    Vector3 m_Yaxis;
    float m_speed;

    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
        m_Yaxis = new Vector3(0, 5, 0);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            m_Rigidbody.constraints = RigidbodyConstraints.FreezeAll;
        } 
    }
}
