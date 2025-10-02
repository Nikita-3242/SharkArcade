using UnityEngine;

public class FishMovement : MonoBehaviour
{
    public float speed = 2;
    private Rigidbody2D body;
    public GameObject waterSurface;
    public GameObject waterSplash;
    public bool inWater = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        waterSurface = GameObject.Find("WaterSurface");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 move = Vector3.right;
        move.Normalize();
        body.AddRelativeForce(move *  speed);

        if (transform.position.y < waterSplash.transform.position.y)
        {
            body.gravityScale = 0;
            body.linearDamping = 1;
                inWater = true;
        } else
        {
            body.gravityScale = 1;
            body.linearDamping = 0;
            inWater = false;
        }
    }
}
