using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Events;
public class SwitchRotator : MonoBehaviour
{

    [HideInInspector] public UnityEvent OnEndingRotating;
    [SerializeField] private Switcher _switcher;
    [SerializeField] private float _timer;
   
    private void Awake()
    {
        _switcher.OnSwitchAngle.AddListener(Rotate);
    }

    
    private void Rotate(Vector3 angle)
    {
        
        StartCoroutine(Rotated(angle));
    }
    private IEnumerator Rotated(Vector3 angle)
    {
        float _currentTimer = 0;
        Quaternion quaternionAngle = new Quaternion();
        quaternionAngle = Quaternion.Euler(angle.x, angle.y, angle.z);
        while (_currentTimer < _timer)
        {
            
            transform.localRotation = Quaternion.RotateTowards(transform.localRotation, quaternionAngle, _currentTimer  / _timer );
            _currentTimer += Time.deltaTime;
            yield return null;
        }
        transform.rotation = quaternionAngle;
        OnEndingRotating.Invoke();

    }
}
