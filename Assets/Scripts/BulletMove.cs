using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{
    [SerializeField] float speed;

    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
    }
}
