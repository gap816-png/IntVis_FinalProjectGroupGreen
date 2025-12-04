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


    void Start()
    {
    


    }
    void Update() 
    {
        
        
    }

    public void OnSceneChangeBt()
    {
        for (int i = 0; i < parentImageList.Count; i++)
        {
            for (int j = 0; j < parentImageList[i].transform.childCount; j++ )
            {
                parentImageList[i].transform.GetChild(j).gameObject.SetActive(false);
            }
        }

        SceneIndex = SceneManager.GetActiveScene().buildIndex;
        parentImageList[SceneIndex].GetComponent<ManageImageList>().imageList[0].SetActive(true);

    }
    //need another button to turn em off?

}