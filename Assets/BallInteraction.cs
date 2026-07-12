using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class BallInteraction : MonoBehaviour
{
    [SerializeField] private float interactionDistance = 2.5f;
    [SerializeField] private float kickForce = 8f;
    [SerializeField] private float upwardForce = 1f;

    private Transform player;
    private Rigidbody ballRigidbody;

    private void Awake()
    {
        ballRigidbody = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        GameObject playerObject =
            GameObject.FindGameObjectWithTag("Player");

        if (playerObject != null)
        {
            player = playerObject.transform;
        }
    }

    private void Update()
    {
        if (player == null)
        {
            return;
        }

        float distance = Vector3.Distance(
            transform.position,
            player.position
        );

        if (
            distance <= interactionDistance &&
            Input.GetKeyDown(KeyCode.E)
        )
        {
            KickBall();
        }
    }

    private void KickBall()
    {
        Vector3 direction =
            player.forward + Vector3.up * upwardForce;

        ballRigidbody.AddForce(
            direction.normalized * kickForce,
            ForceMode.Impulse
        );
    }
}