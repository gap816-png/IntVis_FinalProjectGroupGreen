using UnityEngine;

public class Play_Animation_OnClick : MonoBehaviour
{
    public  Animator animator;
     public GameObject animatorOBJ;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     public void PlayAnimation()
    {
        animator = animatorOBJ.GetComponent<Animator>();

        animator.SetBool("TrStartBool", true);
    }
}
