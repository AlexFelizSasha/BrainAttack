using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MathMultiplicationTask
{
    private int _firstNumber;
    private int _secondNumber;


    public MathMultiplicationTask(int minNumber, int maxNumber)
    {
        _firstNumber = Random.Range(minNumber, maxNumber);
        do
            _secondNumber = Random.Range(minNumber, maxNumber);
        while (_secondNumber < 2);
    }

    public object GetTrueResult() { return _firstNumber * _secondNumber; }
    public object GetFirstFalseResult() { return FirstFalseResult(); }
    public object GetSecondFalseResult() { return SecondFalseResult(); }
    public object GetThirdFalseResult() { return ThirdFalseResult(); }
    public object GetFirstNumber() { return _firstNumber; }
    public object GetSecondNumber() { return _secondNumber; }

    private int FirstFalseResult()
    {
        return _firstNumber * (_secondNumber + 1);
    }
    private int SecondFalseResult()
    {
        return _firstNumber * (_secondNumber - 1);
    }
    private int ThirdFalseResult()
    {
        if (_firstNumber == _secondNumber)
            return _firstNumber * _secondNumber + 4;
        else
            return (_firstNumber + 1) * _secondNumber;
    }
}
