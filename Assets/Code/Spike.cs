using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spike : MonoBehaviour
{
    public ParticleSystem spikeblood;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.CompareTag("Player"))
        {
            spikeblood.Play();  
            StartCoroutine(DelaySceneReload());
        }
    }

    IEnumerator DelaySceneReload()
    {
        yield return new WaitForSeconds(spikeblood.main.duration);
        SceneManager.LoadScene("Level 1");
    }
}

