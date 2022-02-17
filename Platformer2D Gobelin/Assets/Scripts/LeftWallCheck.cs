using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftWallCheck : MonoBehaviour
{
    public PlayerController player;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ground"))
        {
            player.isWalledLeft = true;
        }
    }
    
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Ground"))
        {
            player.isWalledLeft = false;
        }
    }
}
