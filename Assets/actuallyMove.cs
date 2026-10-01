using UnityEngine;
using System.Collections;

public class actuallyMove : MonoBehaviour
{
    public float rotationSpeed = 0.01f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {    
       // transform.rotation = Quaternion.Euler(xRotation, yRotation, zRotation);
        
       // if (Input.GetKeyDown(KeyCode.UpArrow))
       // {
       //     Debug.Log("up pressed");
      //      upPressed = true;
       // }

       // if (upPressed)
       // {
            
       // }
            
       // }
        


        float tiltX = Input.GetAxis("Vertical") * rotationSpeed * Time.deltaTime;
        float tiltZ = Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;
        transform.Rotate(tiltX, 0, tiltZ);
    }
    }


