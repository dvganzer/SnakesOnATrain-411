using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crates : MonoBehaviour
{

    public GameObject[] spawner;
    public Transform pos;
    public AudioSource crateBreak;
    private void Start()
    {
       //crate = GetComponent<Transform>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        int randomIndex = Random.Range(0, spawner.Length);
        if (collision.gameObject.tag == "Bullet")
        {
            // Instantiate(spawner[randomIndex], pos);
            crateBreak.Play();
            Destroy(gameObject);
        }
    }
}
