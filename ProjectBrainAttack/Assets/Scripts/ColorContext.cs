using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorContext
{
    private Dictionary<int, Color> _colors = new Dictionary<int, Color>();

    private const string RED = "red";
    private const string WHITE = "white";
    private const string GREEN = "green";
    private const string BLACK = "black";
    private const string YELLOW = "yellow";
    private const string BLUE = "blue";

    public ColorContext()
    {
        _colors.Add(0, Color.red);
        _colors.Add(1, Color.white);
        _colors.Add(2, Color.green);
        _colors.Add(3, Color.black);
        _colors.Add(4, Color.yellow);
        _colors.Add(5, Color.blue);
    }
    public Dictionary<Color, string> GetColorNameDictionary()
    {
        Dictionary<Color, string> _colorNames = new Dictionary<Color, string>();
        _colorNames.Add(_colors[0], RED);
        _colorNames.Add(_colors[1], WHITE);
        _colorNames.Add(_colors[2], GREEN);
        _colorNames.Add(_colors[3], BLACK);
        _colorNames.Add(_colors[4], YELLOW);
        _colorNames.Add(_colors[5], BLUE);

        return _colorNames;
    }

    public Color GetColor(int color)
    {
        return _colors[color];
    }

    public int GetColorsCount()
    {
        return _colors.Count;
    }
}
