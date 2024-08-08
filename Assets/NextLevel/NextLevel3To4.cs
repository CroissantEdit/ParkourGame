using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class NextLevel3to4 : MonoBehaviour
{
    public int NextScene;
    void Start()
    {
        
    }

    void Update()
    {
        
    }
     void OnTriggerEnter2D(Collider2D Trigger)
    {
        if (Trigger.CompareTag("Player"))
        {
            SceneManager.LoadScene("Level 4");
        }
    }
}
