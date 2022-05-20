using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class charaterScript : MonoBehaviour
{

    private bool isInArea=true;
    private Vector3 move;
    private float speed=8;
    private int cubeCount, capsuleCount;
    [SerializeField] private TMP_Text cubeText, capsuleText;

  

    void Update()
    {
        if(transform.position.x < -6.99f || transform.position.x > 6.99f)
        {
            isInArea = false;
        }
        else
        {
            isInArea = true;
        }
        if (isInArea == true)
        {
            move = new Vector3(Input.GetAxis("Horizontal") * speed, 0, speed);

            transform.Translate(move * Time.deltaTime);
        }
        else
        {
            if (transform.position.x <  -6.99f)
            {
                if (Input.GetAxis("Horizontal") <= 0)
                {
                    move = new Vector3(0, 0, speed);
                    transform.Translate(move * Time.deltaTime);

                }
                else
                {
                    move = new Vector3(Input.GetAxis("Horizontal") * speed, 0, speed);
                    transform.Translate(move * Time.deltaTime);

                }
            }
            if (transform.position.x > 6.99)
            {
                if (Input.GetAxis("Horizontal") >= 0)
                {
                    move = new Vector3(0, 0, speed);
                    transform.Translate(move * Time.deltaTime);

                }
                else
                {
                    move = new Vector3(Input.GetAxis("Horizontal") * speed, 0, speed);
                    transform.Translate(move * Time.deltaTime);

                }
            }



        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "cube")
        {
            cubeCount++;
            cubeText.text = "" + cubeCount;
        }
        else if (other.gameObject.tag == "capsule")
        {
            capsuleCount++;
            capsuleText.text = "" + capsuleCount;
        }
        if (other.gameObject.tag == "Finish")
        {
            Time.timeScale = 0;
        }
    }
}
