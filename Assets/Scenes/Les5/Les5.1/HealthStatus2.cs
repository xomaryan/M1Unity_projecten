using UnityEngine;

public class HealthStatus2 : MonoBehaviour
{
    public int health = 100;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            health -= 10;
            CheckHealth();
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            health += 10;
            CheckHealth();
        }
    }

    void CheckHealth()
    {
        if (health > 50)
        {
            Debug.Log("Good health!");
        }
        else if (health > 20)
        {
            Debug.Log("Warning: Low health!");
        }
        else if (health > 0)
        {
            Debug.Log("Critical: Very low health!");
        }
        else
        {
            Debug.Log("Game Over!");
        }
    }
}
