using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PingSpeed : MonoBehaviour
{
    public float moveSpeed;
    public float rotSpeed;
    [SerializeField] Transform target;
    void Update()
    {
        transform.Translate(0, -moveSpeed * Time.deltaTime, 0);
        transform.Rotate(0, rotSpeed * Time.deltaTime, 0);
        if(transform.position.y < target.position.y + 2f)
        {
            Vector3 resetPos = new Vector3(transform.position.x, target.position.y + 5f, transform.position.z);
            transform.position = resetPos; 
        }
    }
}
