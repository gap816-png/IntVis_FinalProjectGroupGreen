using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using System.Collections;

public class UIManager : MonoBehaviour
{

//Current build scene set to 0 as it's always 0 to begin with 
    private int currentBuildIndex = 0;
    public static UIManager instance = null;
    
    [SerializeField]
    private TextMeshProUGUI myTMPText;
    
    void Awake() //awake starts before void Start
   {
    if (instance == null)
    {
        instance = this;
    }
    else
    {
        Destroy(gameObject); //have to specify gameObject, can't use "this" just because of the destroy function.
        return; //without this return, unity will crash lol it loops forever or some shit
    }

     DontDestroyOnLoad(this); //you can also put gameObject instead and that would work
     FindCurrentIndex(); //find current build index too make sure we are at 0 when the game begins
     Debug.Log("Current scene index" + currentBuildIndex);
   }

    void Update()
    {
        myTMPText.text = SceneManager.GetActiveScene().name;
        Debug.Log("Current scene index" + currentBuildIndex);
    }


//when pressing the next button
    public void OnNextSceneBtClick()
    {
       //if current build index variable is less than 1, then we can move up scenes, make sure to change this number from 1 to the total number of [scenes -1.]
        if(currentBuildIndex < 1) //once we add more scenes, this number becomes total number of scenes -1 *********
        {
           
           //we create a new variable called newsceneIndex which is equal to the current scene index + 1
            int newsceneIndex = currentBuildIndex + 1;
            //loading the next scene as we pass through the newsceneIndex which is just the current scene index +1 which is the next scene 
            SceneManager.LoadScene(newsceneIndex);
            

            //to check if we're moving up scenes
            Debug.Log("We moving up scenes");
        }
        //then we start the coroutine here to find what the index of the current scene is
        StartCoroutine(WaitForEndOfFrame());

       
       //can add a quit here and a return*******************FOR FINAL BUILD ADD THIs  
    }

//when pressing the back button
    public void OnBackSceneBtClick() //button for back
    {
         //when we add in main menu scene with skeleton hand, that will be the new index 0, so we will change number to 1. ************
        if(currentBuildIndex > 0) // if current build index is greater than 0 (not in scene 1), we can go back to previous scene
        {   
            // again we create a new variable called newsceneIndex which is equal to the current scene index - 1
            int newsceneIndex = currentBuildIndex - 1;

            SceneManager.LoadScene(newsceneIndex); //loading the next scene as we pass through the newsceneIndex which is just the current scene index -1 which is the previous scene 

            //to check if we're moving down scenes
            Debug.Log("We moving down scenes :()");
        }
        //then we start the coroutine here to find what the index of the current scene is
        StartCoroutine(WaitForEndOfFrame());
            
       //kerri said we can just delete the back button from the 1st scene OR can add an if statement instance as 
       //can add a quit here and a return*******************FOR FINAL BUILD ADD THIS
        
    }

//method to find current scene index
    private void FindCurrentIndex()
    {
        //we are just setting the current scene index by getting the index of the active scene 
        currentBuildIndex = SceneManager.GetActiveScene().buildIndex;
    }

/*This Coroutine is extremly important, it ensures our current scene is updating correctly
    we tell is to wait one frame then find what the current index is */
    private IEnumerator WaitForEndOfFrame()
    {
        yield return null;
        FindCurrentIndex();
        Debug.Log("Current scene index" + currentBuildIndex);
    }
}

/*The coroutine is important as when we load the next scene in unity the build index only updates during the next frame, 
even though the scene is loaded visually in current frame, if we dont use the coroutine it will take the current build index of the current frame
which does not always match the actual scene as the build index updates the next frame, so we wait till the next frame and grab the build index then*/
