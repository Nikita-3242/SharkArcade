using System.Collections;
using UnityEngine;

public class FishSpawner : MonoBehaviour
{
    public GameObject fish;

    public float spawnTime = 4;
    public float minX = -10;
    public float maxX = 10;
    public float minY = -10;
    public float maxY = 10;  

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(spawnFish());
    }

    IEnumerator spawnFish()
    {
       
        while (true)
        {
            yield return new WaitForSeconds(spawnTime);
            float xSpawn = Random.Range(minX, maxX);
            float ySpawn = Random.Range(minY, maxY);
            Vector3 spawnPos = new Vector3(xSpawn, ySpawn, 0);
            Instantiate(fish, spawnPos, transform.rotation);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
