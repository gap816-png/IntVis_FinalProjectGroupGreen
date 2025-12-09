using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public Animator anim1;
    public Animator anim2;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            LaunchAnim();
        }
    }

    public void LaunchAnim()
    {
        
            anim1.enabled= true;
            anim2.enabled= true;

    }
}
