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
    public MathMultiplicationTask CreateMathMultiplicationTask(int minNumber, int maxNumber)
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
    public ColorTask CreateColorTask()
    {
        ColorTask _colorTask = new ColorTask();
        OnTaskCreated?.Invoke(this, new OnTaskCreatedEventArgs()
        {
            taskObject = _colorTask.GetTaskObject(),
            trueResult = _colorTask.GetTrueResult(),
            firstFalseResult = _colorTask.GetFirstFalseResult(),
            secondFalseResult = _colorTask.GetSecondFalseResult(),
            thirdFalseResult = _colorTask.GetThirdFalseResult()
        });
        return _colorTask;
    }
}
