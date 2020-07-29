using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{

    public float speed;
    public Transform startPoint, endPoint;

    private void Start()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
    }

    // Update is called once per frame
    void Update()
    {

        if(transform.position.x >= endPoint.position.x)
        {
            transform.rotation = Quaternion.Euler(Vector3.up * 180);
            GetComponent<Rigidbody2D>().velocity = Vector2.left * speed;

        }
        if (transform.position.x <= startPoint.position.x)
        {
            transform.rotation = Quaternion.Euler(Vector3.zero);
            GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;


        }


    }
}
