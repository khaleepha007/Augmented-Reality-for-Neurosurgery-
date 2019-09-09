using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.WSA.Input;

public class gazescript : MonoBehaviour
{
    public static gazescript Instance { get; private set; }

    private Vector3 moveDirection = Vector3.zero;

    public GameObject FocusedObject { get; private set; }

    GestureRecognizer recognizer;
    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
        recognizer = new GestureRecognizer();
        recognizer.TappedEvent += (source, tapCount, ray) =>
        {
            if (FocusedObject != null)
            {
                FocusedObject.SendMessageUpwards("OnSelect");
            }
        };
        recognizer.StartCapturingGestures();
    }

    // Update is called once per frame
    void Update()
    {
        GameObject oldfocusObject = FocusedObject;
        var headPosition = Camera.main.transform.position;
        var gazeDirection = Camera.main.transform.forward;

        RaycastHit hitInfo;
        if(Physics.Raycast(headPosition, gazeDirection, out hitInfo))
        {
            FocusedObject = hitInfo.collider.gameObject;
        }
        else
        {
            FocusedObject = null;
        }
        if(FocusedObject != oldfocusObject)
        {
            recognizer.CancelGestures();
            recognizer.StartCapturingGestures();
        }
    }
}
