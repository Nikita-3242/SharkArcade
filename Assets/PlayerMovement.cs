using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float speed = 2;
    private float useSpeed = 50;
    private Rigidbody2D body;
    public GameObject waterSurface;
    public GameObject waterSplash;
    public bool inWater = true;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");
        Vector3 move = new Vector3(ver, hor, 0);
        move.Normalize();
        body.AddRelativeForce(move * useSpeed);

        if (transform.position.y < waterSurface.transform.position.y)
        {
            body.gravityScale = 0;
            body.linearDamping = 1;
            useSpeed = speed;

            if (!inWater)
            {
                Vector3 splashPos = transform.position;
                splashPos.y = waterSurface.transform.position.y;
                GameObject splashClone = Instantiate(waterSplash, splashPos, Quaternion.identity);
                Destroy(splashClone, 0.5f);
            }

            inWater = true;
        }
        else
        {
            body.gravityScale = 1;
            body.linearDamping = 0;
            useSpeed = 0;

            if (inWater)
            {
                Vector3 splashPos = transform.position;
                splashPos.y = waterSurface.transform.position.y;
                GameObject splashClone = Instantiate(waterSplash, splashPos, Quaternion.identity);
                Destroy(splashClone, 0.5f);
            }

            inWater = false;
        }
    }
}