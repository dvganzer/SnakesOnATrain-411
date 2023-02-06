using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InstructionsExit : MonoBehaviour
{
    public GameObject instructions;
    public GameObject buttons;
    public void OnExit()
    {
        instructions.SetActive(true);
        buttons.SetActive(false);
    }

    public void OnClose()
    {
        instructions.SetActive(false);
        buttons.SetActive(true);
    }
}
