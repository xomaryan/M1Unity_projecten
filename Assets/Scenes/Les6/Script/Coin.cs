using UnityEngine;

public class Coin : MonoBehaviour
{
    public Vector3 rotateAmount;
    void Start()
    {
        Debug.Log("Hello Player! Welcome to the game!");
        Debug.Log("In this game you have to collect all the coins. Good luck!");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotateAmount * Time.deltaTime);
    }

}      
