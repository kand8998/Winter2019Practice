using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class BoolData : ScriptableObject
{
    private bool toggle = true;
    public GameAction trueAction;

    private void SetBoolTrue()
    {
        trueAction.action += SetBoolFalse;
    }

    private void SetBoolFalse()
    {
        trueAction.Raise();
    }
}
