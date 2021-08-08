using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RotateCoin : MonoBehaviour
{
    PlayerController playerController;
    GameManager gameManager;
    
    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }
    void Update()
    {
        transform.Rotate(0,0,90*Time.deltaTime);
    }
    private void OnTriggerEnter(Collider other)
    {
        playerController = other.GetComponent<PlayerController>();
        if(playerController)
        {
            Destroy(gameObject);
            gameManager.count++;
        
        }
        
    }
}
