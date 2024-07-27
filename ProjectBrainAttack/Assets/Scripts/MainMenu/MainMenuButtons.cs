using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuButtons : MonoBehaviour
{
    [SerializeField] Button _mathButton;
    [SerializeField] Button _colorsButton;
    [SerializeField] Button _settingsButton;

    public static event Action OnMathButtonClicked;
    public static event Action OnColorButtonClicked;
    public static event Action OnSettingsButtonClicked;

    private void Start()
    {
        _mathButton.onClick.AddListener(() =>
        {
            OnMathButtonClicked?.Invoke();
        });

        _colorsButton.onClick.AddListener(() =>
        {
            OnColorButtonClicked?.Invoke();
        });

        _settingsButton.onClick.AddListener(() =>
        {
            OnSettingsButtonClicked?.Invoke();
        });
    }
}
