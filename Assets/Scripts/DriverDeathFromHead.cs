using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DriverDeathFromHead : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collison)
    {
        if (collison.gameObject.CompareTag("Ground"))
        {
            GameManager.instance.GameOver();
        }
    }
}
