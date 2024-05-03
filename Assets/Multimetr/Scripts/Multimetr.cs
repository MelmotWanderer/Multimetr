using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Multimetr : MonoBehaviour
{
    [HideInInspector] public UnityEvent<float> OnUpdatedValueUI;
    [SerializeField] private Switcher _switcher;
    [SerializeField] private SwitchRotator _rotator;
    [SerializeField] private List<Mode> _modes;
    private Mode _currentMode;
    private int _currentIndexMode;
    private float _currentResultCalculation;
    

    private void Awake()
    {
        _switcher.OnSwitchModeLeft.AddListener(SwitchModeLeft);
        _switcher.OnSwitchModeRight.AddListener(SwitchModeRight);
        _rotator.OnEndingRotating.AddListener(UpdateUI);

         _currentMode = _modes[0];
        _currentMode.Init();
        _currentIndexMode = 0;
    }
    public void SwitchMode(int step)
    {
        _currentMode.Stop();
        if (_currentIndexMode + step == _modes.Count)
        {
            _currentIndexMode = 0;
            _currentMode = _modes[_currentIndexMode];
        }
        else if (_currentIndexMode + step == -1)
        {
            _currentIndexMode = _modes.Count - 1;
            _currentMode = _modes[_currentIndexMode];
        }
        else
        {
            _currentIndexMode += step;
            _currentMode = _modes[_currentIndexMode];
        }

        _currentMode.Init();
        _currentResultCalculation = _currentMode.GetResult();


    }
    public Vector3 GetAngleSwitcherCurrentMode()
    {
        return _currentMode.GetAngle();
    }
    
    private void SwitchModeRight()
    {
        SwitchMode(1);
    }
    private void SwitchModeLeft()
    {
        SwitchMode(-1);
    }
    private void UpdateUI()
    {
        OnUpdatedValueUI?.Invoke(_currentResultCalculation);
    }
    
}
