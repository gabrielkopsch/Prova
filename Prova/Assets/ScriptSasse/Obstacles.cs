using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
{

    PlayerController controller;
    private void OnTriggerEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Obstacle" || collision.gameObject.tag == "Player")
        {

            Debug.Log("perdeu");
            //controller.GameOver();
        }
    }
}
