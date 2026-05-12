using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    GameObject currentCollectible;

    int collCount = 0;
    int currentScore = 0;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Contains("Collectible"))
        {
            currentCollectible = other.gameObject;
        }

        if (other.gameObject.tag == "GoalArea" && collCount >= 7)
        {
            print("Player entered trigger zone with " + collCount + " collectibles");
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject == currentCollectible)
        {
            currentCollectible = null;
        }
    }

    void OnInteract()
    {
        if (currentCollectible != null)
        {
            currentScore += currentCollectible.GetComponent<CollectibleScript>().collectibleScore;

            ++collCount;

            print("Current score: " + currentScore);

            Destroy(currentCollectible);

            currentCollectible = null;
        }
    }
}