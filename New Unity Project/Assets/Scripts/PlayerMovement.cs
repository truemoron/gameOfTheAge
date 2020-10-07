using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public int sidewayForce = 15;
    public int forwardForce = 1000;
    public bool gameIsActive = true;


    // Update is called once per frame
    void FixedUpdate()
    {
        if (gameIsActive == true)
        {
            rb.AddForce(forwardForce * Time.deltaTime, 0, 0);
        }



        if (Input.GetKey("d"))
        {
            rb.AddForce(0, 0, -sidewayForce * Time.deltaTime, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(0, 0, sidewayForce * Time.deltaTime, ForceMode.VelocityChange);
        }


        if (GetComponent<Transform>().position.y <= 0)
        {
            FindObjectOfType<GameManager>().GameOver();
        }
    }
}
