using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MathTaskUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _firstNumberText;
    [SerializeField] private TextMeshProUGUI _secondNumberText;

    private void Start()
    {
        TaskFabric.OnTaskCreated += TaskFabric_OnTaskCreated;
    }

    private void TaskFabric_OnTaskCreated(object sender, TaskFabric.OnTaskCreatedEventArgs e)
    {
        _firstNumberText.text = e.firstTaskObject.ToString();
        _secondNumberText.text = e.secondTaskObject.ToString();
    }
}
