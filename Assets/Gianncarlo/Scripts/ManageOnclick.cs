using UnityEngine;

public class ManageOnclick : MonoBehaviour
{
    public void OnClickStart()
    {
        GameManager.myUICanvas.SetActive(true); //this one doesnt need an instance as its a part of unity
        UIManager.instance.OnNextSceneBtClick(); //this one needs an instance because I believe its static and a public variable.
    }
}
//matt made this code to fix the Start Button from losing its OnMethodClick Events going back to the main menu
