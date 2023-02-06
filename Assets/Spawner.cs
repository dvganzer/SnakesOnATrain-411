using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] spawner;
    public Transform pos;
   

    void Start()
    {
        int randomIndex = Random.Range(0, spawner.Length);
        
        Instantiate(spawner[randomIndex],pos );
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
