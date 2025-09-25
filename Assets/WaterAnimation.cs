using UnityEngine;

public class WaterAnimation : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private Rigidbody2D body;
    public GameObject waterSurface;
    public GameObject waterSplash;
    public bool inWater = true;
    private Vector3 offset = new Vector3(0, 650, 0);

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        waterSurface = GameObject.Find("WaterSurface");
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < waterSurface.transform.position.y + offset.y)
        {
            body.gravityScale = 0;
            body.linearDamping = 1;

            if (!inWater)
            {
                Vector3 splashPos = transform.position;
                splashPos.y = waterSurface.transform.position.y + offset.y;
                GameObject splashClone = Instantiate(waterSplash, splashPos, Quaternion.identity);
                Destroy(splashClone, 0.5f);
            }

            inWater = true;
        } else
        {
            
            body.gravityScale = 1;
            body.linearDamping = 0;
            if (inWater)
            {
                Vector3 splashPos = transform.position;
                splashPos.y = waterSurface.transform.position.y + offset.y;
                GameObject splashClone = Instantiate(waterSplash, splashPos, Quaternion.identity);
                Destroy(splashClone, 0.5f);
            }
            inWater = false;
        }

    }
}
