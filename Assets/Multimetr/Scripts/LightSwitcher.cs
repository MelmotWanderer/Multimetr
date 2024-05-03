using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitcher : MonoBehaviour
{
    [SerializeField] private Light _light;
    [SerializeField] private float _intensityStart;
    [SerializeField] private float _intensityFull;
    [SerializeField] private float _timer;

    private void Start()
    {
        _light.intensity = _intensityStart;
    }
    public void EnableLight()
    {
      
        StartCoroutine(UpIntensity());
    }

    public void DisableLight()
    {
        StopAllCoroutines();
        StartCoroutine(DownIntensity());
        
    }

    private IEnumerator UpIntensity()
    {
        float _currentTimer = 0;
        while(_currentTimer < _timer)
        {

            _light.intensity = Mathf.Lerp(_light.intensity, _intensityFull, _currentTimer/ _timer);
            _currentTimer += Time.deltaTime;
            yield return null;
        }
        _light.intensity = _intensityFull;
    }
    private IEnumerator DownIntensity()
    {
        float _currentTimer = 0;
        while (_currentTimer < _timer)
        {

            _light.intensity = Mathf.Lerp(_light.intensity, _intensityStart, _currentTimer / _timer);
            _currentTimer += Time.deltaTime;
            yield return null;
        }
        _light.intensity = _intensityStart;
    }
}
