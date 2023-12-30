using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class VIDE : MonoBehaviour
{
    public UIManager ui;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Matt"))
        {
            ui.Settimer();
            SceneManager.LoadScene("DefaiteManager");
        }
    }
}
