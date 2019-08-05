using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionInfo : MonoBehaviour
{
    
    public Movement player;
    void start()
    {
        
    }
     void OnTriggerEnter(Collider other)
    {
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+2);
            
    }
}
