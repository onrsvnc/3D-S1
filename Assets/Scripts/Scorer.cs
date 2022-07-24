using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int bumped = 0;
    private void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.tag != "Hit")
        {
            bumped ++;
            Debug.Log("You've bumped into a thing this many times: " + bumped);
        }
    }

}
