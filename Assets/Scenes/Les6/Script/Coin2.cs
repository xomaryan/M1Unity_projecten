using UnityEngine;

public class Coin2 : MonoBehaviour
{
    public Vector3 rotateAmount;
   
    
    void Update()
    {
        transform.Rotate(rotateAmount * Time.deltaTime);
    }

}      


