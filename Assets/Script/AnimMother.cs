using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimMother : MonoBehaviour
{
    public Animator maman;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void moitier()
    {
        maman.SetTrigger("moitié");
    }
    public void fin()
    {
        maman.SetTrigger("fin");
    }
}
