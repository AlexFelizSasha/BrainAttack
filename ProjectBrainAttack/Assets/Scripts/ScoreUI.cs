using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _scoreText;
    [SerializeField] private TextMeshProUGUI _tasksAmountText;

    private void Start()
    {
        TrueGateTrigger.OnScoreAdd += TrueGateTrigger_OnScoreAdd;

        TrueGateTrigger.OnTaskAmountAdd += GateTrigger_OnTaskAmountAdd;
        FalseGateTrigger.OnTaskAmountAdd += GateTrigger_OnTaskAmountAdd;

    }

    private void OnDisable()
    {
        TrueGateTrigger.OnScoreAdd -= TrueGateTrigger_OnScoreAdd;

        TrueGateTrigger.OnTaskAmountAdd -= GateTrigger_OnTaskAmountAdd;
        FalseGateTrigger.OnTaskAmountAdd -= GateTrigger_OnTaskAmountAdd;
    }

    private void GateTrigger_OnTaskAmountAdd()
    {
        ChangeTaskAmount();
    }

    private void TrueGateTrigger_OnScoreAdd()
    {
        ChangeScore();
    }
    private void ChangeScore()
    {
        string _text = ScoreManager.GetScore().ToString();
        _scoreText.text = _text;
    }
    private void ChangeTaskAmount()
    {
        string _text = ScoreManager.GetTaskAmount().ToString();
        _tasksAmountText.text = _text;
    }

}
