using UnityEngine;

public class ManageObjCursor : MonoBehaviour
{
    [SerializeField]
    private GameObject myCursorObj;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray myRay = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit hit;

        Debug.DrawRay(myRay.origin, myRay.direction*100.0f, Color.red);

        myCursorObj.transform.position = myRay.origin + myRay.direction*1.0f;

    }
}
