using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class BoolData : ScriptableObject
{
    private bool boolValue;
    public GameAction trueAction;

    private void SetBoolTrue()
    {
        trueAction.action = SetBoolFalse;
        boolValue = true;
    }

    private void SetBoolFalse()
    {
        boolValue = false;
        trueAction.Raise();
    }
}
