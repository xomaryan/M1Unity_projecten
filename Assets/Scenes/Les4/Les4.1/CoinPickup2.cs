using UnityEngine;

public class CoinPickup2 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player picked up a coin!");
            ScoreManager2.instance.AddScore(1);
            Destroy(gameObject);
        }
    }

}
