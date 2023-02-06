using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class InsideTrainCart1 : MonoBehaviour
{
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            SceneManager.LoadScene("TrainCart1");
        }
    }
}
