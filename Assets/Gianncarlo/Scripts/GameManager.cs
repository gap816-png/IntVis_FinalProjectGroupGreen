using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

  //public UIManager myIUManager;
   public static GameObject myUICanvas;

   public int sceneIndex = 0;
   public static GameManager instance = null; //makes sure there aren't any duplicates of the GameManager, this is due to "static" 

   

   void Awake() //awake starts before void Start
   {
    if (instance == null)
    {
        instance = this;
        myUICanvas = this.transform.GetChild(0).GetChild(0).gameObject;

    }
    else
    {
        Destroy(gameObject); //have to specify gameObject, can't use "this" just because of the destroy function.
        return; //without this return, unity will crash lol it loops forever or some shit
    }

     DontDestroyOnLoad(this); //you can also put gameObject instead and that would work
     //Init();
   }

   /*void Init()
   {
     SceneManager.LoadScene(sceneIndex);
     sceneIndex +=1;
     
   } */
}
