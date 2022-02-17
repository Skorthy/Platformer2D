using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightWallCheck : MonoBehaviour
{
    public PlayerController player;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ground"))
        {
            player.isWalledRight = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Ground"))
        {
            player.isWalledRight = false;
        }
    }
}    
