using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorContext
{
    private Dictionary<int, string> _colors = new Dictionary<int, string>();

    private const string RED = "red";
    private const string WHITE = "white";
    private const string GREEN = "green";
    private const string BLACK = "black";
    private const string YELLOW = "yellow";
    private const string BLUE = "blue";

    public ColorContext()
    {
        _colors.Add(0, RED);
        _colors.Add(1, WHITE);
        _colors.Add(2, GREEN);
        _colors.Add(3, BLACK);
        _colors.Add(4, YELLOW);
        _colors.Add(5, BLUE);
    }

    public string GetColor(int color)
    {
        return _colors[color];
    }

    public int GetColorsCount()
    {
        return _colors.Count;
    }
    public Dictionary<int, string> GetFalseColors(int trueColorIndex)
    {
        _colors.Remove(trueColorIndex);
        return _colors;
    }
}
