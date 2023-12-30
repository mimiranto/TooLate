using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoryManager : MonoBehaviour
{
    public static int passagelevel;
    

    public void backmenu()
    {
        SceneManager.LoadScene(0);
    }
    public void nextlevel()
    {
        passagelevel += 1;
        SceneManager.LoadScene(passagelevel + 1);
        
    }
}
