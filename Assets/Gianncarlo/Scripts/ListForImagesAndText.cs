using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListForImagesAndText : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> parentImageList = new List<GameObject>();

    [SerializeField]
    private List<GameObject> imageList = new List<GameObject>();

    private int currentBuildIndex = 0;
    public int images;

    void Update() 
    {
    
    if (Input.GetKeyDown(KeyCode.Space))
       {
            for (parentImageList = 0; parentImageList < transform.childCount; parentImageList++)
            {
                transform.GetChild(parentImageList).gameObject.SetActive(false);

                if (imageList.Contains(transform.GetChild(parentImageList).gameObject))
                {
                    transform.GetChild(parentImageList).gameObject.SetActive(true);
                }
            }
    
        }   
    }
}

