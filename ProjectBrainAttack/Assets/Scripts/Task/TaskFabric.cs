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
        public object firstTaskObject;
        public object secondTaskObject;
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
            firstTaskObject = _mathMultiplicationTask.GetFirstTaskObject(),
            secondTaskObject = _mathMultiplicationTask.GetSecondTaskObject(),
            trueResult = _mathMultiplicationTask.GetTrueResult(),
            firstFalseResult = _mathMultiplicationTask.GetFirstFalseResult(),
            secondFalseResult = _mathMultiplicationTask.GetSecondFalseResult(),
            thirdFalseResult = _mathMultiplicationTask.GetThirdFalseResult()
        });
        return _mathMultiplicationTask;
    }
}