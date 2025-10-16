using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotation : MonoBehaviour
{
    void Update()
    {
        Vector3 mouse = Input.mousePosition;
        Vector3 mouseInUnity = Camera.main.ScreenToWorldPoint(mouse);
        Vector3 player = transform.position;
        Vector3 look = mouseInUnity - player;
        look.z = 0;
        transform.right = -look;

        SpriteRenderer renderer = GetComponent<SpriteRenderer>();

        float x = look.x;
        if (x > 0)
        {
            renderer.flipY = true;
        }
        else
        {
            renderer.flipY = false;
        }
    }
}