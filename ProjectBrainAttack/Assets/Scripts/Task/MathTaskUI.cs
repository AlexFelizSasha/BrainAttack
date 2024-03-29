using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MathTaskUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _taskText;

    private void Start()
    {
        TaskFabric.OnTaskCreated += HandleCreatedTask;
    }
    private void OnDisable()
    {
        TaskFabric.OnTaskCreated -= HandleCreatedTask;
    }

    private void HandleCreatedTask(object sender, TaskFabric.OnTaskCreatedEventArgs e)
    {
        _taskText.text = e.taskObject.ToString();
    }
}
