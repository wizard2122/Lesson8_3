using System;
using UnityEngine;

public class Health: IHealthStat
{
    public event Action Died;

    public Health(int maxHealth)
    {
        MaxHealth = Value = maxHealth;
        Debug.Log($"�������� ��������: {Value}");
    }

    public int MaxHealth { get; }

    public int Value { get; private set; }

    public void Add(int value)
    {
        if(value < 0)
            throw new ArgumentOutOfRangeException(nameof(value));

        Value += value;

        if(Value > MaxHealth)
            Value = MaxHealth;

        Debug.Log($"�������� ��������: {Value}");
    }

    public void Reduce(int value)
    {
        if (value < 0)
            throw new ArgumentOutOfRangeException(nameof(value));

        Value -= value;

        if(Value <= 0)
        {
            Value = 0;
            Died?.Invoke();
        }

        Debug.Log($"�������� ��������: {Value}");
    }
}
