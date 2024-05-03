using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModeResistance : Mode
{
    public override void Init()
    {
        _modeCalculation = new ModeResistanceCalculation();
        Calculate();
        UpdateUIValueMode.Invoke(_currentResultCalculation);
    }
    
}
