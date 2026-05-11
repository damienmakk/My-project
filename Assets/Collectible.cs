using UnityEngine;

public class Collectible : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "PlayerCapsule")
        {
            Destroy(gameObject);
        }
    }
}