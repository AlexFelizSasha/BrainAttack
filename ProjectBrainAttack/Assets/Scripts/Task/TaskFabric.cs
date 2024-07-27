using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class TaskFabric
{
    public static event EventHandler<OnTaskCreatedEventArgs> OnTaskCreated;

    public class OnTaskCreatedEventArgs : EventArgs
    {
        public object taskObject;
        public object trueResult;
        public object firstFalseResult;
        public object secondFalseResult;
        public object thirdFalseResult;
    }

    public void CreateTask()
    {
        //ColorTask _colorTask = CreateColorTask();
        MathMultiplicationTask _mathTask = CreateMathMultiplicationTask(11, 21);
    }
    private MathMultiplicationTask CreateMathMultiplicationTask(int minNumber, int maxNumber)
    {
        MathMultiplicationTask _mathMultiplicationTask = new MathMultiplicationTask(minNumber, maxNumber);
        OnTaskCreated?.Invoke(this, new OnTaskCreatedEventArgs()
        {
            taskObject = _mathMultiplicationTask.GetTaskObject(),
            trueResult = _mathMultiplicationTask.GetTrueResult(),
            firstFalseResult = _mathMultiplicationTask.GetFirstFalseResult(),
            secondFalseResult = _mathMultiplicationTask.GetSecondFalseResult(),
            thirdFalseResult = _mathMultiplicationTask.GetThirdFalseResult()
        }) ;
        return _mathMultiplicationTask;
    }
    private ColorTask CreateColorTask()
    {
        ColorTask _colorTask = new ColorTask();
        OnTaskCreated?.Invoke(this, new OnTaskCreatedEventArgs()
        {
            taskObject = (Color)_colorTask.GetTaskObject(),
            trueResult = (Color)_colorTask.GetTrueResult(),
            firstFalseResult = (Color)_colorTask.GetFirstFalseResult(),
            secondFalseResult = (Color)_colorTask.GetSecondFalseResult(),
            thirdFalseResult = (Color)_colorTask.GetThirdFalseResult()
        });
        return _colorTask;
    }
}
