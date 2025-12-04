using UnityEngine;

public class PlayAnimationOnClick : MonoBehaviour
{

    public Animator animator;

    public GameObject animatorOBJ;

    

    
    public void Start()
    {
        animator = animatorOBJ.GetComponent<Animator>();

        
    }

    public void PlayAnimation()
    {
        animator.SetBool("TrStartBool", true);
    }

   
}
