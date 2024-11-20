using UnityEngine;
using UnityEngine.Playables; // Required for PlayableDirector

public class TriggerTimelinePlay : MonoBehaviour
{
    [SerializeField] private PlayableDirector timeline; // Assign the PlayableDirector in the Inspector
    [SerializeField] private string playerTag = "Player"; // The tag to identify the player object

    private void OnTriggerEnter(Collider other)
    {
        // Check if the object entering the trigger has the correct tag
        if (other.CompareTag(playerTag))
        {
            // Play the timeline
            if (timeline != null)
            {
                timeline.Play();
            }
            else
            {
                Debug.LogError("No PlayableDirector assigned to the script.");
            }
        }
    }
}