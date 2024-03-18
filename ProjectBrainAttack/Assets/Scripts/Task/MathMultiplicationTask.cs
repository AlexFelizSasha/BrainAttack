using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MathMultiplicationTask
{
    private int _firstNumber;
    private int _secondNumber;

    public MathMultiplicationTask(int minNumber, int maxNumber)
    {
        _firstNumber = UnityEngine.Random.Range(minNumber, maxNumber);
        do
            _secondNumber = UnityEngine.Random.Range(minNumber, maxNumber);
        while (_secondNumber < 2);
    }

    public object GetTrueResult() { return CountTrueResult(); }
    public object GetFirstFalseResult() { return CountFirstFalseResult(); }
    public object GetSecondFalseResult() { return CountSecondFalseResult(); }
    public object GetThirdFalseResult() { return CountThirdFalseResult(); }
    public object GetTaskObject() { return CreateTaskText(); }

    
    private int CountTrueResult()
    {
        return _firstNumber * _secondNumber;
    }
    private int CountFirstFalseResult()
    {
        return _firstNumber * (_secondNumber + 1);
    }
    private int CountSecondFalseResult()
    {
        return _firstNumber * (_secondNumber - 1);
    }
    private int CountThirdFalseResult()
    {
        if (_firstNumber == _secondNumber)
            return _firstNumber * _secondNumber + 4;
        else
            return (_firstNumber + 1) * _secondNumber;
    }

    private string CreateTaskText()
    {
        string _text = $"{_firstNumber} x {_secondNumber}";
        return _text;
    }
}
