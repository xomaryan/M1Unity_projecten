using UnityEngine;

public class Rotate : MonoBehaviour
{
    
    public Vector3 rotateAmount;
    void Start()
    {
        Debug.Log("hallo Unity!");
    }


    void Update()
    {
        transform.Rotate(rotateAmount * Time.deltaTime);
    }
}
