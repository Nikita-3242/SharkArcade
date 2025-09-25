using NUnit.Framework.Internal;
using Unity.VisualScripting;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public string characterName = "Shark";
    public float speed = 5f;
    public Vector2 direction = new Vector2(10, 12);
     private Rigidbody2D rb;
    void Start()
    { 
        rb = GetComponent<Rigidbody2D>();
    
        Debug.Log($"Имя персонажа- {characterName}");
        Debug.Log($"Скорость- {speed}");
        transform.position = direction;
    }
     
    private void Update()
    {
        //Vector3 mouse = Input.mouseposition;
        //Vector3 mouseInUnity = Camera.main.ScreenToWorldPoint(mouse);
        //Vector3 player = transform.position;
        //Vector3 look = mouseInUnity - player;
        //look.z = 0;
        //transform.right = look;

        //SpriteRenderer renderer = Getcomponent<SpriteRenderer>();
        //if (look.x < 0)
        //{
        //    renderer.flipY = true;
        //}
        //else
        //{
        //    renderer.flipY = false;
        //}

        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");
        Vector3 move = new Vector3(hor, ver, 0);
        move.Normalize();
        rb.AddRelativeForce(move * speed);
    }


}
