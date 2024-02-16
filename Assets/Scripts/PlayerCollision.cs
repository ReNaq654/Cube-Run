using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstacle")
        {
            movement.enabled = false; //Disable's Player Movement
            FindObjectOfType<GameManager>().EndGame(); //Calls EndGame() method in GameManager.cs
        }
    }
}
