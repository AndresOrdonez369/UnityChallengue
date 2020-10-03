using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionsX : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Dog"))
        {
            ScoreScript.scoreValue += 1;
            Destroy(this.gameObject); //Destruyo el animal
            Destroy(other.gameObject); //Destruyo lo otros
        }
    }
}
