using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModeNeutral : Mode
{
    public override void Init()
    {
        _modeCalculation = new ModeNeutralCalculation();
        Calculate();
        UpdateUIValueMode.Invoke(_currentResultCalculation);
    }
   
}
