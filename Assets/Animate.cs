using UnityEngine;

public class Animate : MonoBehaviour
{
    Animator animator;


    public float horizontal;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Awake()
    {
        animator = GetComponentInChildren<Animator>();
    }

   void Update()
   {    
        animator.SetFloat("Horizontal",horizontal);


   }
}
