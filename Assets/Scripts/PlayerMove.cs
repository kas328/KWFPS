using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] Transform cameraTransform;

    [SerializeField] float moveSpeed = 10f;
    [SerializeField] float jumpSpeed = 10f;
    [SerializeField] float gravity = -20f;
    [SerializeField] float yVelocity = 0;
    CharacterController cc;
    void Awake()
    {
        cc = GetComponent<CharacterController>();
    }

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 moveDir = new Vector3(h, 0, v);
        moveDir = cameraTransform.TransformDirection(moveDir);
        moveDir *= moveSpeed;

        if(cc.isGrounded)
        {
            yVelocity = 0;
            if(Input.GetKeyDown(KeyCode.Space))
            {
                yVelocity = jumpSpeed;
            }
        }

        yVelocity += gravity * Time.deltaTime;
        moveDir.y = yVelocity;
        cc.Move(moveDir * Time.deltaTime);
    }
}
