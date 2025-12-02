using UnityEngine;

public class MaximizeText : MonoBehaviour
{
     [SerializeField]
    private GameObject myCursorTextMax;

    // Update is called once per frame
   /* void Update()
    {
        Ray myRay = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit hit;

        Debug.DrawRay(myRay.origin, myRay.direction*100.0f, Color.red);

        myCursorObj.transform.position = myRay.origin + myRay.direction*1.0f;

    } */

    public void MyMaximizeText()
    {
        Ray myRay = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit hit;

        Debug.DrawRay(myRay.origin, myRay.direction*100.0f, Color.blue);

        myCursorTextMax.transform.position = myRay.origin + myRay.direction*1.0f;
    } 

    //add another piece of code so that when you press "-", image minimizes
}
