using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Timer : MonoBehaviour
{
    [SerializeField] private Text uiText;
    [SerializeField] private float mainTimer;

    private float timer;
    private bool canCount=true;
    private bool doOnce=false;


    void Start()
    {
        timer=mainTimer;

    }
    void Update()
    {
        if(timer>=0.0f&& canCount)
        {
            timer-=Time.deltaTime;
            uiText.text=timer.ToString("F0");
        }
        else if(timer<=0.0f&& !doOnce)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
        }
    }
    
}
