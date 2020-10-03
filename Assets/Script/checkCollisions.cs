using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class checkCollisions : MonoBehaviour
{
    
    
    //Se llama automaticamente por el api de Unity 

   
    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Projectile"))
        {

            ScoreScript.scoreValue += 1;          
            Destroy(this.gameObject); //Destruyo el animal
            Destroy(other.gameObject); //Destruyo lo otros
        }
      
    }
}
