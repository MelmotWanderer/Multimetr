using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
[RequireComponent(typeof(TMP_Text))]
public class UIValueMode : MonoBehaviour
{

    [SerializeField] private Mode _mode;
    private TMP_Text _text;

    private void Awake()
    {
        _mode.UpdateUIValueMode.AddListener(UpdateUI);
        _text = GetComponent<TMP_Text>();
    }

    private void UpdateUI(float result)
    {
        _text.text = result.ToString();
    }

}
