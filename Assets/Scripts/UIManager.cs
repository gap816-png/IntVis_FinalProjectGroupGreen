using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class UIManager : MonoBehaviour
{

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
    }

    public void OnNextSceneBtClick()
    {
        if(GameManager.instance.sceneIndex >= SceneManager.sceneCountInBuildSettings)
        {
              GameManager.instance.sceneIndex = 1;
        }

        SceneManager.LoadScene(GameManager.instance.sceneIndex);
        GameManager.instance.sceneIndex +=1;
       
       //can add a quit here and a return*******************FOR FINAL BUILD ADD THIS
        
    }

    public void OnBackSceneBtClick()
    {
        if(GameManager.instance.sceneIndex >= SceneManager.sceneCountInBuildSettings)
        {
              GameManager.instance.sceneIndex = 1;
        }
        //3 scenes so far
        SceneManager.LoadScene(GameManager.instance.sceneIndex);
        GameManager.instance.sceneIndex -=1;
       
       //can add a quit here and a return*******************FOR FINAL BUILD ADD THIS
        
    }
  
}
