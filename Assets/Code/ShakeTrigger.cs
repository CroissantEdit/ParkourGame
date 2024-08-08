using System.Collections;
using System.Collections.Generic;
using FirstGearGames.SmoothCameraShaker;
using UnityEngine;

public class ShakeTrigger : MonoBehaviour
{
    public ShakeData ShakeData;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

     void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Player"))
        {
            CameraShakerHandler.Shake(ShakeData);
        }
    }
}
