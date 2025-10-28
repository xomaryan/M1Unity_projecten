using UnityEngine;

public class CoinPickup : MonoBehaviour
{
    public int coinValue = 10;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player picked up a coin!");
            ScoreManager.instance.AddScore(coinValue);
            Destroy(gameObject);
        }
    }
}
