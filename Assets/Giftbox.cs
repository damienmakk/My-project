using UnityEngine;

public class GiftBox : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private GameObject ballPrefab;
    [SerializeField] private Transform ballSpawnPoint;
    [SerializeField] private float interactionDistance = 2.5f;
    [SerializeField] private int requiredPresses = 3;

    private int pressCount;
    private bool isOpened;

    private void Update()
    {
        if (isOpened || player == null)
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
            pressCount++;

            Debug.Log(
                "GiftBox presses: " +
                pressCount +
                "/" +
                requiredPresses
            );

            if (pressCount >= requiredPresses)
            {
                OpenGiftBox();
            }
        }
    }

    private void OpenGiftBox()
    {
        isOpened = true;

        Instantiate(
            ballPrefab,
            ballSpawnPoint.position,
            ballSpawnPoint.rotation
        );

        Destroy(gameObject);
    }
}