using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorTask : ITaskable
{
    private string _trueColor;
    private string _firstFalseColor;
    private string _secondFalseColor;
    private string _thirdFalseColor;

    public ColorTask()
    {
        ColorContext _colorContext = new ColorContext();
        int _colorsCount = _colorContext.GetColorsCount();
        int _colorIndex = Random.Range(0, _colorsCount);
        _trueColor = _colorContext.GetColor(_colorIndex);
        _firstFalseColor = _colorContext.GetFalseColors(_colorIndex)[Random.Range(0, _colorsCount - 1)];
        _secondFalseColor = _colorContext.GetFalseColors(_colorIndex)[Random.Range(0, _colorsCount - 1)];
        _thirdFalseColor = _colorContext.GetFalseColors(_colorIndex)[Random.Range(0, _colorsCount - 1)];
    }

    public object GetTaskObject()
    {
        return _trueColor;
    }
    public object GetTrueResult()
    {
        return _trueColor;
    }
    public object GetFirstFalseResult()
    {
        return _firstFalseColor;
    }
    public object GetSecondFalseResult()
    {
        return _secondFalseColor;
    }
    public object GetThirdFalseResult()
    {
        return _thirdFalseColor;
    }    
}
