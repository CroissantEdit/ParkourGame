using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using FirstGearGames.SmoothCameraShaker;
public class ParticleTrigger : MonoBehaviour
{
    public ParticleSystem Blood;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

     void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Player"))
        {
            Blood.Play();
        }
    }
}
