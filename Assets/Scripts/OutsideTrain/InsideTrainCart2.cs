using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InsideTrainCart2 : MonoBehaviour
{

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            SceneManager.LoadScene("TrainCart2");
        }
    }
}
