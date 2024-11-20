using UnityEngine;
using UnityEngine.Playables;

public class TimelineAnimatorControl : MonoBehaviour
{
    [SerializeField] private PlayableDirector timeline; // Assign the timeline in the Inspector
    [SerializeField] private Animator[] animators; // Assign the Animator components to manage

    private void Start()
    {
        // Ensure all Animators are disabled at the start
        foreach (Animator animator in animators)
        {
            if (animator != null)
                animator.enabled = false;
        }
    }

    private void OnEnable()
    {
        if (timeline != null)
            timeline.stopped += OnTimelineStopped;
    }

    private void OnDisable()
    {
        if (timeline != null)
            timeline.stopped -= OnTimelineStopped;
    }

    public void OnTimelineStopped(PlayableDirector director)
    {
        // Disable all Animators after the timeline ends
        foreach (Animator animator in animators)
        {
            if (animator != null)
                animator.enabled = false;
        }
    }
}

