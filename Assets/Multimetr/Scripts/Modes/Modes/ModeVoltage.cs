using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModeVoltage : Mode
{
    private float _power;
    private float _resistance;

    
    public override void Init()
    {
        _power = this.GetComponent<ModesData>().GetPower();
        _resistance = this.GetComponent<ModesData>().GetResistance();
        _modeCalculation = new ModeVoltageCalculation(_power, _resistance);
        Calculate();
        UpdateUIValueMode.Invoke(_currentResultCalculation);
    }
    
}
