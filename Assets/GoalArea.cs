using UnityEngine;

public class GoalArea : MonoBehaviour
{
    [SerializeField] private ScoreManager scoreManager;
    [SerializeField] private int scoreAmount = 1;

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Ball"))
        {
            return;
        }

        scoreManager.AddScore(scoreAmount);

        Debug.Log("Goal scored!");
    }
}