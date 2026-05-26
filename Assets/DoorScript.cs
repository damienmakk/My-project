using UnityEngine;

public class DoorScript : MonoBehaviour
{
    Animator myAnimator; // Reference to the Animator component that controls the door's animations, editable from the Unity Inspector

    bool isOpen = false; // Track whether the door is currently open or closed, starting as closed by default

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myAnimator = GetComponentInParent<Animator>(); // Get the Animator component attached to this GameObject so we can control the door's animations
    }
    public void Interact()
    {
        if(myAnimator != null)
        {
            if(!isOpen)
            myAnimator.SetTrigger("DoorOpen"); // Trigger the "DoorClose" animation to play when the door is currently open and we want to close it
        else
        myAnimator.SetTrigger("DoorClose");
        
        isOpen = !isOpen; // Toggle the isOpen state to reflect the new state
        }
    }
}