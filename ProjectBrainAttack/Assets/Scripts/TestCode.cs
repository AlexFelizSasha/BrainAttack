using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

public class TestCode : MonoBehaviour
{    
    
    void Start()
    {

        //TaskFabric _taskFabric = new TaskFabric();
        //MathMultiplicationTask _mathMultiplicationTask = _taskFabric.CreateMathMultiplicationTask(1, 10);
        //Debug.Log("number 1 = " + _mathMultiplicationTask.GetFirstNumber());
        //Debug.Log("number 2 = " + _mathMultiplicationTask.GetSecondNumber());
        //Debug.Log("result = " + _mathMultiplicationTask.GetTrueResult());
        //Debug.Log($"False results = {_mathMultiplicationTask.GetFirstFalseResult()}, {_mathMultiplicationTask.GetSecondFalseResult()}, {_mathMultiplicationTask.GetThirdFalseResult()}");
        //TaskFabric.OnTaskCreated += TaskFabric_OnTaskCreated;
    }

    private void TaskFabric_OnTaskCreated(object sender, TaskFabric.OnTaskCreatedEventArgs e)
    {
        Debug.Log($"Task objects {e.firstTaskObject}, {e.secondTaskObject}");
        
    }

    void Update()
    {
        
    }
}
