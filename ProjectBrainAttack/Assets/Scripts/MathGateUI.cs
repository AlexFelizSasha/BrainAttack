using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MathGateUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _trueGateText;
    [SerializeField] private TextMeshProUGUI _firstFalseGateText;
    [SerializeField] private TextMeshProUGUI _secondFalseGateText;
    [SerializeField] private TextMeshProUGUI _thirdFalseGateText;

    private void Start()
    {
        TaskFabric.OnTaskCreated += TaskFabric_OnTaskCreated;
    }

    private void TaskFabric_OnTaskCreated(object sender, TaskFabric.OnTaskCreatedEventArgs e)
    {
        _trueGateText.text = e.trueResult.ToString();
        _firstFalseGateText.text = e.firstFalseResult.ToString();
        _secondFalseGateText.text = e.secondFalseResult.ToString();
        _thirdFalseGateText.text = e.thirdFalseResult.ToString();
    }
}
