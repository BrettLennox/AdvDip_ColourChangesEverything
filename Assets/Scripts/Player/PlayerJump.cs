using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerGroundCheck))]
public class PlayerJump : MonoBehaviour
{
    #region Variables
    [SerializeField] private Rigidbody2D _rb;
    [SerializeField] [Range(1,10)] private float _jumpMultiplier;
    private float _hiddenJumpMultiplier;
    private GroundCheck _groundCheck;
    private PlayerAnimator _playerAnimator;
    #endregion
    #region Properties

    #endregion

    private void Awake()
    {
        _groundCheck = GetComponent<GroundCheck>();
        _playerAnimator = GetComponentInChildren<PlayerAnimator>();
    }

    // Update is called once per frame
    void Update()
    {
        _hiddenJumpMultiplier = _jumpMultiplier * 100;
        _playerAnimator.IsGrounded = _groundCheck.IsGrounded;

        if (Input.GetKeyDown(KeyCode.Space) && _groundCheck.IsGrounded)
        {
            _rb.AddForce(Vector2.up * _hiddenJumpMultiplier, ForceMode2D.Force);
        }
    }
}
