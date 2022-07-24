using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 1f;

    void Start()
    {

    }


    void Update()
    {
        PlayerMovement();        
    }


    
    void PlayerMovement()
    {
        float xSpeed = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zSpeed = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(xSpeed,0,zSpeed);
    }


}
