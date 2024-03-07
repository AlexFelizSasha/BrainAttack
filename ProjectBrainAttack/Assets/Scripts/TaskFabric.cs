using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class TaskFabric
{
    public MathMultiplicationTask CreateMathMultiplicationTask(int minNumber, int maxNumber)
    {
        MathMultiplicationTask _mathMultiplicationTask = new MathMultiplicationTask(minNumber, maxNumber);
        return _mathMultiplicationTask;
    }
}
