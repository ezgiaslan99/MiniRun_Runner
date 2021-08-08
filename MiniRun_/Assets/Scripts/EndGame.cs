using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndGame : MonoBehaviour
{
    [SerializeField] private Text overtext;
    PlayerController playerController;
    private void OnTriggerEnter(Collider other)
    {
        playerController = other.GetComponent<PlayerController>();
        if(playerController)
        {
            playerController.enabled = false;
            overtext.text = "Congratz";
        }
    }
}
