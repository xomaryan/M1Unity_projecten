using UnityEngine;

public class HealthPickup1 : MonoBehaviour
{
    public int healAmount = 5;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerHealth playerHealth = other.GetComponent<PlayerHealth>();
            if (playerHealth != null && playerHealth.health < playerHealth.maxHealth)
            {
                playerHealth.health += healAmount;
                Debug.Log("Health restored!");
                Debug.Log("Health is now: " + playerHealth.health);
                Destroy(gameObject);
            }
        }
    }
}
