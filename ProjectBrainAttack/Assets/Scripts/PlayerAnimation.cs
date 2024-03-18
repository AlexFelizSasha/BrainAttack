using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    private Animator _playerAnimator;
    private const string PLAYER_JUMPS = "PlayerJumps";
    private void Start()
    {
        _playerAnimator = GetComponent<Animator>();
        PlayerMovement.OnPlayerMoves += PlayerMovement_OnPlayerMoves;
    }
    private void OnDisable()
    {
        PlayerMovement.OnPlayerMoves -= PlayerMovement_OnPlayerMoves;
    }

    private void PlayerMovement_OnPlayerMoves()
    {
        _playerAnimator.SetTrigger(PLAYER_JUMPS);
    }
}
