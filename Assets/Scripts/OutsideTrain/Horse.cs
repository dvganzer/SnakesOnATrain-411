using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Horse : MonoBehaviour
{
    public float Speed = 4.5f;
    public GameObject instructions;
    public Transform player;
    public GameObject players;
    public NewPlayerMovement movement;

    void Start()
    {
        instructions.SetActive(false);
        movement = players.GetComponent<NewPlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.right * Time.deltaTime * Speed;
    }

    public void OnMouseOver()
    {
        instructions.SetActive(true);
        if (Input.GetKeyDown(KeyCode.F))
        {
            instructions.SetActive(false);
            player.transform.position = gameObject.transform.position;
            player.transform.SetParent(this.transform);
            Speed = 15f;
            players.GetComponent<CircleCollider2D>().enabled = false;
            players.GetComponent<BoxCollider2D>().enabled = false;
            players.GetComponent<Rigidbody2D>().gravityScale = 0f;
            
            movement.runSpeed = 0f;

        }

    }
    public void OnMouseExit()
    {
        instructions.SetActive(false);
    }
    /*private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Saddle")
        {
            SceneManager.LoadScene("Title");
        }
    }
    */


}
