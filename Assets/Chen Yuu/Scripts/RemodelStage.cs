using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;



public class RemodelStage : MonoBehaviour
{
    public int maxHealingStage = 3;

    public int myHealingStage = 0;

    public List<GameObject> stageList;
    public List<GameObject> btList;

    int index = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
         
    }
    public void OnClickNext()
    {
        index += 1;
        Debug.Log(index);
        
        if (index >= stageList.Count)
        {
            //Do Something

            return;
      
        }      

        //Disable everythg
        for (int i = 0; i < stageList.Count; i++)
        {
            stageList[i].SetActive(false);
            btList[i].SetActive(false);
        }

        //Active only the object
        stageList[index].SetActive(true);
        btList[index].SetActive(true);
    }
}
