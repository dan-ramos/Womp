using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class WompMovement : MonoBehaviour
{
    public Vector3 moveDirection;
    float timer;
    float moveCycle;
    public float timerCheck;
    public float moveFrequency;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            timer = 0;
            StartCoroutine(Move(Vector3.right)); 
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            timer++;
            moveCycle++;

            if (timer + Time.deltaTime > timerCheck)
            {
                if (moveCycle > moveFrequency)
                {
                    StartCoroutine(Move(Vector3.right));
                    moveCycle = 0;
                }
            }
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            timer = 0;
            StartCoroutine(Move(Vector3.left));
        } 
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            timer++;
            moveCycle++;

            if (timer + Time.deltaTime > timerCheck)
            {
                if (moveCycle > moveFrequency)
                {
                    StartCoroutine(Move(Vector3.left));
                    moveCycle = 0;
                }
            }
        }
    }
        
    IEnumerator Move(Vector3 direction)
    {
        transform.position = transform.position + (direction / 2);
        yield return null;
    }
}
