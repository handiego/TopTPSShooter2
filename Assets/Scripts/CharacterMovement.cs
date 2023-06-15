using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class CharacterMovement : MonoBehaviour
{

    public Transform cameraTransform;
    public CharacterStatus characterStatus;


    public float vertical;
    public float horizontal;
    public float moveAmount;
    public float speed = 7f;

    public Vector3 rotationDirection;
    public Vector3 moveDirection;


    void GetInputButton()
    {
        if (Input.GetKey(KeyCode.W))
        {
            if (Input.GetKey(KeyCode.A) != false || Input.GetKey(KeyCode.D) != false)
            {
                transform.localPosition += transform.forward * speed/2 * Time.deltaTime;
            }
            else
            {
                transform.localPosition += transform.forward * speed * Time.deltaTime;
            }

        }
        if (Input.GetKey(KeyCode.S))
        {
            if (Input.GetKey(KeyCode.A) != false || Input.GetKey(KeyCode.D) != false)
            {
                transform.localPosition += -transform.forward * speed / 2 * Time.deltaTime;
            }
            else
            {
                transform.localPosition += -transform.forward * speed * Time.deltaTime;
            }
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.localPosition += transform.right * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.localPosition += -transform.right * speed * Time.deltaTime;
        }



    }
    public void Update()
    {
        
        vertical = Input.GetAxis("Vertical");
        horizontal = Input.GetAxis("Horizontal");
        moveAmount = Mathf.Clamp01(Mathf.Abs(vertical) + Mathf.Abs(horizontal));

        Vector3 moveDir = cameraTransform.forward * moveAmount;
        
        moveDir.Normalize();
        moveDirection = moveDir;
        rotationDirection = cameraTransform.forward;
        RotationNormal();
        GetInputButton();



    }

    public void RotationNormal()
    {
        if (!characterStatus.isAim)
        {
            rotationDirection = moveDirection;
        }

        Vector3 targetDir = rotationDirection;
        targetDir.y = 0;

        if (targetDir == Vector3.zero)
        
        targetDir = transform.forward;
       

        Quaternion lookDir = Quaternion.LookRotation(targetDir);
        Quaternion targetRot = Quaternion.Slerp(transform.rotation, lookDir, 1);

        transform.rotation = targetRot;
    }
}



