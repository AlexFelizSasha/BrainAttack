using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ColorTaskUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _taskText;
    void Start()
    {
        TaskFabric.OnTaskCreated += HandleCreatedTask;
    }

    private void HandleCreatedTask(object sender, TaskFabric.OnTaskCreatedEventArgs e)
    {
        Color _color = (Color)e.taskObject;
        ColorContext _colorContext = new ColorContext();
        string _text = _colorContext.GetColorNameDictionary()[_color];
        _taskText.text = _text;
    }
}
