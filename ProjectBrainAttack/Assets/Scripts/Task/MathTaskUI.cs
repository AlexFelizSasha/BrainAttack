using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MathTaskUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _taskText;

    private void Start()
    {
        TaskFabric.OnTaskCreated += TaskFabric_OnTaskCreated;
    }

    private void TaskFabric_OnTaskCreated(object sender, TaskFabric.OnTaskCreatedEventArgs e)
    {
        _taskText.text = e.taskObject.ToString();
    }
}
