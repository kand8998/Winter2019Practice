using UnityEngine;

[CreateAssetMenu]
public class AnimController : ScriptableObject
{
    public float animSpeed;
    
    public void AnimCall(Animator animator)
    {
        animator.SetTrigger(name);
    }

    public void AnimSpeed(Animator animator)
    {
        animator.speed = animSpeed;
    }

    public void AnimEventSet(Animator animator)
    {
        animator.fireEvents = true;
    }
}