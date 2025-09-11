using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public string characterName = "Shark";
    public float speed = 5f;
    public Vector2 direction = new Vector2(10, 12);
    void Start()
    {
        Debug.Log($"Имя персонажа- {characterName}");
        Debug.Log($"Скорость- {speed}");
        transform.position = direction;
    }
    
}
