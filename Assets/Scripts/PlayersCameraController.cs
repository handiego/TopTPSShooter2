using System;

using UnityEngine;

public class PlayersCameraController : MonoBehaviour
{
    private float mouseX;
    private float mouseY;

    private float xRotation = 0f;

    

    public float mouseSensivity = 200f;

    public Transform Player;

    void Start()
    { 
        Cursor.lockState = CursorLockMode.Locked;
    }

    
    void Update()
    {
        mouseX = Input.GetAxis("Mouse X") * mouseSensivity * Time.deltaTime;
        mouseY = Input.GetAxis("Mouse Y") * mouseSensivity * Time.deltaTime;
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -70f, 70f);
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

        Player.Rotate(mouseX * new Vector3(0, 1, 0));
        transform.Rotate(-mouseY * new Vector3(1, 0, 0));
        
        

        
        
    }  
}
