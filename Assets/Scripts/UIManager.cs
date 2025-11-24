using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class UIManager : MonoBehaviour
{

    private int currentBuildIndex;
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
   }

    void Update()
    {
        myTMPText.text = SceneManager.GetActiveScene().name;

        currentBuildIndex = SceneManager.GetActiveScene().buildIndex; //resets current build index variable to the active scene index
    }

    public void OnNextSceneBtClick()
    {
        if(GameManager.instance.sceneIndex >= SceneManager.sceneCountInBuildSettings)
        {
              GameManager.instance.sceneIndex = 1;
        }


        //if current build index variable is less than 1, then we can move up scenes, make sure to change this number from 1 to the total number of [scenes -1.]
        if(currentBuildIndex < 1) //once we add more scenes, this number becomes total number of scenes -1 *********
        {
            //loading next scene
            SceneManager.LoadScene(GameManager.instance.sceneIndex);
            GameManager.instance.sceneIndex +=1;

            //to check if we're moving up scenes
            Debug.Log("We moving up scenes");
        }
       
       //can add a quit here and a return*******************FOR FINAL BUILD ADD THIS
        
    }


    public void OnBackSceneBtClick() //button for back
    {
        if(GameManager.instance.sceneIndex >= SceneManager.sceneCountInBuildSettings)
        {
              GameManager.instance.sceneIndex = 1;
        }
         //when we add in main menu scene with skeleton hand, that will be the new index 0, so we will change number to 1. ************
         if(currentBuildIndex > 0) // if current build index is greater than 0 (not in scene 1), we can go back to previous scene
        {   
            //loading previous scene
            SceneManager.LoadScene(GameManager.instance.sceneIndex);
            GameManager.instance.sceneIndex -=1;

            //to check if we're moving down scenes
            Debug.Log("We moving down scenes :()");
        }
            
       //kerri said we can just delete the back button from the 1st scene OR can add an if statement instance as 
       //can add a quit here and a return*******************FOR FINAL BUILD ADD THIS
        
    }
  
}
