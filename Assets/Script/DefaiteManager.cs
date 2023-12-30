using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DefaiteManager : MonoBehaviour
{
    public void retry()
    {
        SceneManager.LoadScene(VictoryManager.passagelevel +1);
    }
    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }
}
