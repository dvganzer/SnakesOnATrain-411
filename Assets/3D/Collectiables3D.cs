using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Collectiables3D : MonoBehaviour
{


    public int Score;
    public Text playerScore;
    public AudioSource cash;
    public AudioSource gem;
    public AudioSource hurt;
    public AudioSource bag;
    public int Health = 3;
    public Image gem1;
    public Image gem2;
    public Image gem3;
    public Sprite jewel;



    private void Start()
    {
        Score = 0;

    }

    private void Update()
    {
        playerScore.text = ("$" + Score);
    }


    private void OnTriggerEnter(Collider collision)
    {


        if (collision.gameObject.tag == "Gem")
        {
            Score += Random.Range(100, 200);
            gem.Play();
            Debug.Log(Score);
            Destroy(collision.gameObject);

        }
        if (collision.gameObject.name == "Gem1")
        {
            gem1.sprite = jewel;
        }
        if (collision.gameObject.name == "Gem2")
        {
            gem2.sprite = jewel;
        }
        if (collision.gameObject.name == "Gem3")
        {
            gem3.sprite = jewel;
        }
        if (collision.gameObject.tag == "Coin")
        {
            Score += 10;
            Debug.Log(Score);
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "Bag")
        {
            Score += Random.Range(50, 100);
            bag.Play();
            Destroy(collision.gameObject);
            Debug.Log(Score);
        }
        if (collision.gameObject.tag == "Cash")
        {

            Score += 50;
            cash.Play();
            Destroy(collision.gameObject);
            Debug.Log(Score);
        }
        if (collision.gameObject.tag == "ExitDoor")
        {
            SceneManager.LoadScene("Level1");
        }
        if (collision.gameObject.tag == "Snake")
        {
            Health--;
            hurt.Play();
            Score -= Random.Range(10, 50);
        }
    }
}
