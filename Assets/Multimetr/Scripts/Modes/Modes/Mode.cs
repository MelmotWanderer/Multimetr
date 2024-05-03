using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public abstract class Mode : MonoBehaviour 
{
    [HideInInspector] public UnityEvent<float> UpdateUIValueMode;
    [SerializeField] protected Vector3 _switchRotateAngle;
    protected IMode _modeCalculation;
    protected float _currentResultCalculation;
   
    public Vector3 GetAngle()
    {
        return _switchRotateAngle;
    }
    abstract public void Init();
    virtual public void Stop()
    {
        _currentResultCalculation = 0;
        UpdateUIValueMode.Invoke(_currentResultCalculation);
    }
    virtual public float GetResult()
    {
        
        return _currentResultCalculation;
    }
    virtual protected void Calculate()
    {
      
       _currentResultCalculation= _modeCalculation.Calculate();
    }
    
}
