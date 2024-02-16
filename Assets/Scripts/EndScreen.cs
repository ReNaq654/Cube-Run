using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndScreen : MonoBehaviour
{
    public void QuitGame()
    {
        Debug.Log("Game Exited");
        Application.Quit();
    }
}
