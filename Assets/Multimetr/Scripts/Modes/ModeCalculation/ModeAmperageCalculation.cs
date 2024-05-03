using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModeAmperageCalculation : IMode
{
    private float _power;
    private float _resistance;
    public ModeAmperageCalculation(float power, float resistance)
    {
        _power = power;
        _resistance = resistance;
    }

    public float Calculate()
    {
        
        return (float)Math.Round(Mathf.Sqrt(_power/_resistance), 2);
    }  
}
