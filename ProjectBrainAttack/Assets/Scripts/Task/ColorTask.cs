using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorTask : ITaskable
{
    private Color _trueColor;
    private Color _firstFalseColor;
    private Color _secondFalseColor;
    private Color _thirdFalseColor;

    public ColorTask()
    {
        ColorContext _colorContext = new ColorContext();
        int _colorsCount = _colorContext.GetColorsCount();
        int _colorIndex = Random.Range(0, _colorsCount);
        _trueColor = _colorContext.GetColor(_colorIndex);
        //int _falseIndex1;
        //do
        //    _falseIndex1 = Random.Range(0, _colorsCount - 1);
        //while (_falseIndex1 == _colorIndex);
        //_firstFalseColor = _colorContext.GetFalseColors(_colorIndex)[_falseIndex1];
        //int _falseIndex2;
        //do
        //    _falseIndex2 = Random.Range(0, _colorsCount - 1);
        //while (_falseIndex2 == _colorIndex || _falseIndex2 == _falseIndex1);
        //_secondFalseColor = _colorContext.GetFalseColors(_colorIndex)[_falseIndex2];
        //int _falseIndex3;
        //do
        //    _falseIndex3 = Random.Range(0, _colorsCount - 1);
        //while (_falseIndex3 == _colorIndex || _falseIndex2 == _falseIndex3 || _falseIndex3 == _falseIndex1);
        //_thirdFalseColor = _colorContext.GetFalseColors(_colorIndex)[_falseIndex3];
        do
            _firstFalseColor = _colorContext.GetColor(Random.Range(0, _colorsCount));
        while (_firstFalseColor == _trueColor);
        do
            _secondFalseColor = _colorContext.GetColor(Random.Range(0, _colorsCount));
        while (_secondFalseColor == _trueColor || _secondFalseColor == _firstFalseColor);
        do
            _thirdFalseColor = _colorContext.GetColor(Random.Range(0, _colorsCount));
        while (_thirdFalseColor == _trueColor || _thirdFalseColor == _firstFalseColor || _thirdFalseColor == _secondFalseColor);
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
