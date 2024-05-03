using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class UIValue : MonoBehaviour
{
    [SerializeField] private Multimetr _multimetr;
    [SerializeField] private TMP_Text _text;
    private void Awake()
    {
        _multimetr.OnUpdatedValueUI.AddListener(UpdateValueUI);
    }

    private void UpdateValueUI(float value)
    {
        _text.text = value.ToString();
    }
}
