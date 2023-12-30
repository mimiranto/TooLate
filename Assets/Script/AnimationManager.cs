using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationManager : MonoBehaviour
{
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void avance(float vitesse)
    {
        animator.SetFloat("vitesse", vitesse);
    }
    public void saut()
    {
        animator.SetTrigger("Jump");
    }
}
