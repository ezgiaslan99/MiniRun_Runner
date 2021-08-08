using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Obstacle : MonoBehaviour
{
    PlayerController playerController;
    private void OnTriggerEnter(Collider other)
    {
        playerController = other.GetComponent<PlayerController>();
        if (playerController)
        {

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

    }
}
