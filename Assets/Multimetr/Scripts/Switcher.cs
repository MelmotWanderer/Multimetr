using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class Switcher : MonoBehaviour
{
    [HideInInspector] public UnityEvent OnSwitchModeRight;
    [HideInInspector] public UnityEvent OnSwitchModeLeft;
    [HideInInspector] public UnityEvent<Vector3> OnSwitchAngle;

    [SerializeField] private Multimetr _multimetr;
    [SerializeField] private LightSwitcher _lightSwitcher;
   
    private bool isEnabled;
    private void Update()
    {
        if (isEnabled)
        {
            if (Input.GetAxisRaw("Mouse ScrollWheel") > 0)
            {
                OnSwitchModeRight.Invoke();
                OnSwitchAngle.Invoke(_multimetr.GetAngleSwitcherCurrentMode());


            }
            if (Input.GetAxisRaw("Mouse ScrollWheel") < 0)
            {
                OnSwitchModeLeft.Invoke();
                OnSwitchAngle.Invoke(_multimetr.GetAngleSwitcherCurrentMode());
               
            }
        }

    }
    
    private void OnMouseOver()
    {
        _lightSwitcher.EnableLight();

        SetEnabled(true);
    }
   
    private void OnMouseExit()
    {
        SetEnabled(false);
        _lightSwitcher.DisableLight();
    }
    private void SetEnabled(bool enabled)
    {
        isEnabled = enabled;
    }
}
