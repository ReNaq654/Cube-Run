using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;

    public float restartDelay = 1f;

    public GameObject completeLevelUI;

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }
    public AudioSource dieSound;

    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            dieSound.Play();
            Debug.Log("Game Over!");
            Invoke("Restart", restartDelay);
        }
    }

    //Restart Level
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
