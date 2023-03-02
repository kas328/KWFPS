using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    [SerializeField] float sensitivity = 250f;
    [SerializeField] float rotationX;
    [SerializeField] float rotationY;
    float mouseMoveX;
    float mouseMoveY;

    void Update()
    {
        mouseMoveX = Input.GetAxis("Mouse X");
        mouseMoveY = Input.GetAxis("Mouse Y");

        rotationY += mouseMoveX * sensitivity * Time.deltaTime;
        rotationX += mouseMoveY * sensitivity * Time.deltaTime;

        if(rotationX > 25f)
        {
            rotationX = 25f;
        }
        if(rotationX < -30f)
        {
            rotationX = -30f;
        }
        transform.eulerAngles = new Vector3(-rotationX, rotationY, 0f);
    }
}
