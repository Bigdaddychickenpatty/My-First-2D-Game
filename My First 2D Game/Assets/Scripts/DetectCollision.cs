using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
     public int PointValue = 1;

    private GameManager _gameManager;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            //Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
    }
}

