using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModesData : MonoBehaviour
{
    
    [SerializeField] private float _power;
    [SerializeField] private float _resistance;
    public float GetPower()
    {
        return _power;
        
    }
    public float GetResistance()
    {
        return _resistance;
    }

}
