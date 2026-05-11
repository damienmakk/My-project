using UnityEngine;

public class NewComponent : MonoBehaviour
{
    Vector3 valueToMove = new Vector3(0.05f, 0, 0);

    void Update()
    {
        transform.position += valueToMove;

        if (transform.position.x > 5f || transform.position.x < -5f)
        {
            valueToMove.x = -valueToMove.x;
        }

        transform.Rotate(0, 1f, 0);
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision Detected!");
    }
}