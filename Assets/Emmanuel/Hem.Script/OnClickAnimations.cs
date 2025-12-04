using UnityEngine;

public class OnClickAnimations : MonoBehaviour
{
    public Animator thisAnimator;
    
    void Start()
    {
        thisAnimator = gameObject.GetComponent<Animator>();
    }

     void OnMouseDown()
     {
        thisAnimator.SetBool("IsClicked", true);
     }

}        
