using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    private static int _score;
    private static int _taskAmount;

    private void Start()
    {
        TrueGateTrigger.OnScoreAdd += TrueGateTrigger_OnScoreAdd;

        TrueGateTrigger.OnTaskAmountAdd += GateTrigger_OnTaskAmountAdd;
        FalseGateTrigger.OnTaskAmountAdd += GateTrigger_OnTaskAmountAdd;
        _score = 0;
        _taskAmount = 0;
    }

    private void OnDisable()
    {
        TrueGateTrigger.OnScoreAdd -= TrueGateTrigger_OnScoreAdd;

        TrueGateTrigger.OnTaskAmountAdd -= GateTrigger_OnTaskAmountAdd;
        FalseGateTrigger.OnTaskAmountAdd -= GateTrigger_OnTaskAmountAdd;
    }

    private void GateTrigger_OnTaskAmountAdd()
    {
        _taskAmount++;
    }

    private void TrueGateTrigger_OnScoreAdd()
    {
        _score++;
    }
    public static int GetScore()
    {
        return _score;
    }
    public static int GetTaskAmount()
    {
        return _taskAmount;
    }
}
