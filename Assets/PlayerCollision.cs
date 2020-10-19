using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    public GameMonitor GameMonitor;


    private void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "GreenTransition")
        {
            movement.enabled = false;
            FindObjectOfType<GameMonitor>().EndGame();


            
        }
    }

}
  
