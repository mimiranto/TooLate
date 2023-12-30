using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public TMP_Text timer;
    public float templimite;
    public Image jaugeTemp;
    public Color orange;
    public static float timestart;
    
    // Start is called before the first frame update
    void Start()
    {
        timestart = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
            float time = Time.time - timestart;
            int minutes = Mathf.FloorToInt(time / 60);
            int secondes = Mathf.FloorToInt(time - minutes * 60);
            timer.text = System.String.Format("{0}", Mathf.FloorToInt(templimite - time));

            jaugeTemp.fillAmount = time / templimite;

            if (time >= templimite / 4)
                jaugeTemp.color = Color.yellow;
            if (time >= templimite / 2)
                jaugeTemp.color = orange;
            if (time >= templimite / 1.5f)
                jaugeTemp.color = Color.red;
            if (time >= templimite)
            {
                timestart = Time.time;
                SceneManager.LoadScene("DefaiteManager");

            }

        

    }
    public void Settimer()
    {
        timestart = Time.time;
    }
    
    
}
