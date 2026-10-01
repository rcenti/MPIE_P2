using UnityEngine;
using System.Collections;

public class MovingMaze : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("updating");
        
        if (Input.GetKeyDown(KeyCode.Up))
        {
            Debug.Log("up pressed");
        }
        
    }
}
