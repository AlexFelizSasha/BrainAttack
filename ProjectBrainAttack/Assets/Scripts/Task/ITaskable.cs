using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ITaskable
{
    public object GetTrueResult();
    public object GetFirstFalseResult();
    public object GetSecondFalseResult();
    public object GetThirdFalseResult();
    public object GetTaskObject();
}
