using UnityEngine;

public class FishRotation : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    public float rotateTime = 2;
    private float timer = 0;
    void Update()
    {
        timer -= Time.deltaTime;
        Vector3 look = transform.right;
        if (timer <= 0)
        {
            look = Random.insideUnitCircle;
            look.z = 0;
            transform.right = look;

                timer = rotateTime;
        }

    }
}
