using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TP_Scene1 : MonoBehaviour
{
    public UIManager ui;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Matt"))
        {
            ui.Settimer();
            SceneManager.LoadScene("Victoire");
        }
    }
       
}
