using UnityEngine;

public class RotateObject : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.DownArrow))
        {
            Debug.Log("Down");
            transform.Rotate(0.0f, 0.0f, -0.1f, Space.Self);
        }

         else if(Input.GetKey(KeyCode.UpArrow))
        {
            Debug.Log("Up");
            transform.Rotate(0.0f, 0.0f, 0.1f, Space.Self);
        }
    }
}
