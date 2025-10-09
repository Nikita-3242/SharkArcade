using UnityEngine;
using UnityEngine.UI;

public class PlayerMouth : MonoBehaviour
{
    public Text playerScore;
    private int score = 0;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Contains("Fish"))
        {
            Destroy(collision.gameObject);
            score++;
            playerScore.text = score + "";
        }
    }
}
