using System;
using UnityEngine;

[CreateAssetMenu]
public class FloatData : ScriptableObject
{
    public float value;

    private void UpdateValue(float amount)
    {
        value += amount;
    }

    private void UpdateValueLimitZero(float amount)
    {
        if (value >= 0)
        {
            UpdateValue(amount);
        }
        else if (Math.Abs(value) < 0)
        {
            value = 0;
        }
    }

    private void SetAmount(float amount)
    {
        value = amount;
    }
}
