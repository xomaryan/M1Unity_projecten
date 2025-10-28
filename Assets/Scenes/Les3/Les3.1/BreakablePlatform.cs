using UnityEngine;
using System.Collections;

public class BreakablePlatform : MonoBehaviour
{
    
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            StartCoroutine(BreakAfterDelay());
        }
        IEnumerator BreakAfterDelay()
        {
            yield return new WaitForSeconds(6f);
            Destroy(gameObject);
        }
    }

   
}
