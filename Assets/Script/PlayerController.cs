using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10f;
    public Vector2 xRange = new Vector2(-23,23);
    public GameObject projectilPrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Movimiento del personaje
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right*Time.deltaTime * speed * horizontalInput);
        if (transform.position.x < xRange.x)
        {
            transform.position = new Vector3(xRange.x, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange.y)
        {
            transform.position = new Vector3(xRange.y, transform.position.y, transform.position.z);
        }
        // Acciones del personaje
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            //Si entramos aquí, hay que lanzar un proyectil
            Instantiate(projectilPrefab, transform.position, projectilPrefab.transform.rotation);

        }
    }
}
