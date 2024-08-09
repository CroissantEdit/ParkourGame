using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProcedualGen : MonoBehaviour
{
    public GameObject Room;   
    public GameObject Room1;  
    public GameObject Room2;  
    public GameObject Room3;
    public Transform SpawnPoint; 

    void Start()
    {
        SpawnRoom();
    }

    void SpawnRoom()
    {
        int randomIndex = Random.Range(0, 4);   
        GameObject selectedRoom;

        if (randomIndex == 0)
        {
            selectedRoom = Room;
        }
        else if (randomIndex == 1)
        {
            selectedRoom = Room1;
        }
        else if (randomIndex == 2)
        {
            selectedRoom = Room2;
        }
         else 
        {
            selectedRoom = Room3;
        }

        Instantiate(selectedRoom, SpawnPoint.position, Quaternion.identity);

        
    }
}
