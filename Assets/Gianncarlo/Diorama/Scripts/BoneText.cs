using UnityEngine;

public class BoneText : MonoBehaviour
{

    public GameObject label;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void OnMouseEnter()
    {
        label.SetActive(true);
    }

    void OnMouseExit()
    {

        label.SetActive(false);
    }
   
   
}
