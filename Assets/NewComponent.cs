using UnityEngine;
public class NewComponent : MonoBehaviour
{
    Vector3 valueToMove = new Vector3(0.005f, 0, 0);

    void Start()
    {
        
    }

    void Update()
    {
       transform.localPosition += valueToMove;

        if (transform.localPosition.x > 5f || transform.localPosition.x < -5f)
        {
            valueToMove.x = -valueToMove.x;
        }

        transform.Rotate(0, 1f, 0);

        //print(transform.localPosition);
        //print(transform.localRotation);
        //print(transform.localScale);
    }
}