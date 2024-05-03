using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModeACVoltage : Mode
{
    public override void Init()
    {
        _modeCalculation = new ModeACVoltageCalculation();
        Calculate();
        UpdateUIValueMode.Invoke(_currentResultCalculation);
    }
    
}
