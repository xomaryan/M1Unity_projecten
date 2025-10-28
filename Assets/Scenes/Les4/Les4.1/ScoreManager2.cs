using UnityEngine;

public class ScoreManager2 : MonoBehaviour
{
    public static ScoreManager2 instance;
    private int score = 0;

    private void Awake()
    {
        instance = this;
    }

    public void AddScore(int amount)
    {
        score += amount;
        Debug.Log("Score: " + score);
    }
}
