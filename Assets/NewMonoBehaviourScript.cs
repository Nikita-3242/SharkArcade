using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public string characterName = "Shark";
    public float speed = 5f;
    public Vector2 direction = new Vector2(10, 12);
    void Start()
    {
        Debug.Log($"��� ���������- {characterName}");
        Debug.Log($"��������- {speed}");
        transform.position = direction;
    }
    
}
