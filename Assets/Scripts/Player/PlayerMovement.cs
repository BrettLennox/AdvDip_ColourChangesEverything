using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    #region Variables
    [SerializeField] private float _speed = 1f;
    [SerializeField] private Vector2 _moveDir, _smoothMoveDir;
    [SerializeField] private float _smoothStep;
    private PlayerAnimator _playerAnimator;
    [SerializeField] private SpriteRenderer _spriteRenderer;
    #endregion
    #region Properties

    #endregion

    private void Awake()
    {
        _playerAnimator = GetComponentInChildren<PlayerAnimator>();
    }
    // Update is called once per frame
    void Update()
    {
        _moveDir = CalculateMovement(_moveDir);
        transform.position = Vector3.MoveTowards(transform.position, transform.position + new Vector3(_moveDir.x, _moveDir.y, 0), Time.deltaTime * _smoothStep);
        _playerAnimator.IsMoving = _moveDir.x == 0 ? false : true;
        _spriteRenderer.flipX = _moveDir.x == -1 ? true : false;
    }

    private Vector2 CalculateMovement(Vector2 moveDirection)
    {
        moveDirection.x = Input.GetKey(KeyCode.A) ? -1 : Input.GetKey(KeyCode.D) ? 1 : 0;

        return moveDirection;
    }
}
