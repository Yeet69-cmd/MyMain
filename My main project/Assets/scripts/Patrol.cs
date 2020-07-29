using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{
    public float originalSpeed;
    public float speed;
    public Transform startPoint, endPoint;

    private void Start()
    {
        originalSpeed = speed;
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;

        if (transform.position.x >= endPoint.position.x)
        {
            transform.rotation = Quaternion.Euler(Vector3.up * 180);
            speed = -originalSpeed;

        }
        if (transform.position.x <= startPoint.position.x)
        {
            transform.rotation = Quaternion.Euler(Vector3.zero); 
            speed = originalSpeed;

        }


    }
}
