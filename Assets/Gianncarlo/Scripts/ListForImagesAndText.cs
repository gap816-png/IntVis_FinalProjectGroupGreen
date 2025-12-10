using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ListForImagesAndText : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> parentImageList = new List<GameObject>();


    private int currentBuildIndex = 0;
    public int SceneIndex = 1;

    //matt made lots of this code, I modified and did some troublehsooting
    void Start()
    {
    


    }
    void Update() 
    {
        
        
    }

    public void OnSceneChangeBt() //sets the image set to that scene Active along with its children (done through UI) and anything else in the list false.(Matt made this code)
    {
        for (int i = 0; i < parentImageList.Count; i++)
        {
            for (int j = 0; j < parentImageList[i].transform.childCount; j++ )
            {
                parentImageList[i].transform.GetChild(j).gameObject.SetActive(false);
            }
        }

        SceneIndex = SceneManager.GetActiveScene().buildIndex-1;
        parentImageList[SceneIndex].GetComponent<ManageImageList>().imageList[0].SetActive(true);

    } 
    
    public void OnRightArrowChangeBt() //(I made this part, but I might need to make this work better for more than 2 images) 
    // sets the second image in the set to that scene Active along with its children 
    // (done through UI) and anything else in the list false
    {
        for (int i = 0; i < parentImageList.Count; i++)
        {
            for (int j = 0; j < parentImageList[i].transform.childCount; j++ )
            {
                parentImageList[SceneIndex].GetComponent<ManageImageList>().imageList[0].SetActive(false);
            }
        }

        SceneIndex = SceneManager.GetActiveScene().buildIndex-1;
        parentImageList[SceneIndex].GetComponent<ManageImageList>().imageList[1].SetActive(true);

    }
}
