using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    #region Variables
    [SerializeField] private float _speed = 1f;
    [SerializeField] private Vector2 _moveDir;
    [SerializeField] private float _smoothStep;
    [SerializeField] private float _previousXDir = 1;
    [SerializeField] private Vector2 _previousMoveVelocity;
    [SerializeField] private bool _changedDirectionMidJump = false;
    private PlayerAnimator _playerAnimator;
    [SerializeField] private SpriteRenderer _spriteRenderer;

    private GroundCheck _groundCheck;
    #endregion
    #region Properties

    #endregion

    private void Awake()
    {
        _playerAnimator = GetComponentInChildren<PlayerAnimator>();
        _groundCheck = GetComponent<GroundCheck>();
    }
    // Update is called once per frame
    void Update()
    {
        if (_groundCheck.IsGrounded)
        {
            _changedDirectionMidJump = false;
            _moveDir = CalculateMovement(_moveDir);
            transform.position = Vector3.MoveTowards(transform.position, transform.position + new Vector3(_moveDir.x, _moveDir.y, 0), Time.deltaTime * _smoothStep);
            _previousMoveVelocity = _moveDir;
            _playerAnimator.IsMoving = _moveDir.x == 0 ? false : true;
            _spriteRenderer.flipX = _previousXDir != 1 ? true : false;

            if (_moveDir.x != 0)
            {
                _previousXDir = _moveDir.x;
            }
        }
        else
        {
            _moveDir = CalculateMovement(_moveDir);
            if (_moveDir != _previousMoveVelocity)
            {
                transform.Translate(_moveDir * (_speed / 2) * Time.deltaTime);
                _changedDirectionMidJump = true;
            }
            else
            {
                if (!_changedDirectionMidJump)
                {
                    transform.Translate(_previousMoveVelocity * _speed * Time.deltaTime);
                }
                else
                {
                    transform.Translate(_moveDir * (_speed / 2) * Time.deltaTime);
                }
            }
        }
    }

    private Vector2 CalculateMovement(Vector2 moveDirection)
    {
        moveDirection.x = Input.GetKey(KeyCode.A) ? -1 : Input.GetKey(KeyCode.D) ? 1 : 0;

        return moveDirection;
    }
}
