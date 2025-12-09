using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManageCamera : MonoBehaviour
{


    public GameObject objToLookAt;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Debug.Log("Right Arrow Pressed");
            transform.Translate(0.1f, 0.0f,0.0f, Space.Self);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            Debug.Log("Left Arrow Pressed");
            transform.Translate(-0.1f, 0.0f,0.0f, Space.Self);
        }
        else{}

        transform.GetChild(0).LookAt(objToLookAt.transform);
    }
}
