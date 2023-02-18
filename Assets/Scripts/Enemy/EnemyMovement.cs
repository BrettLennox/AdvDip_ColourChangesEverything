using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;
    [SerializeField] private Transform _leftFoot, _rightFoot, _leftEye, _rightEye;
    [SerializeField] private Rigidbody2D _rb2D;
    [SerializeField] private SpriteRenderer _spriteRenderer;

    private EnemyCollisionCheck _collisionCheck;
    private WorldObjectsCycleDisplay _display;

    // Start is called before the first frame update
    void Awake()
    {
        _collisionCheck = GetComponent<EnemyCollisionCheck>();
        _display = GetComponent<WorldObjectsCycleDisplay>();
    }

    private void Start()
    {
        _collisionCheck.GroundRayOrigin = _leftFoot;
        _collisionCheck.WallRayOrigin = _leftEye;
        _collisionCheck.WallRayDir = _collisionCheck.WallRayOrigin == _leftEye ? new Vector2(-1,0) : new Vector2(1,0);
    }

    // Update is called once per frame
    void Update()
    {
        if (_display.ColourMatch())
        {
            _rb2D.bodyType = RigidbodyType2D.Dynamic;
            transform.Translate(MoveDir() * Time.deltaTime);

            if (!_collisionCheck.IsGrounded)
            {
                _collisionCheck.GroundRayOrigin = _collisionCheck.GroundRayOrigin == _leftFoot ? _rightFoot : _leftFoot;
            }
            if (_collisionCheck.HitWall)
            {
                _collisionCheck.WallRayOrigin = _collisionCheck.WallRayOrigin == _leftEye ? _rightEye : _leftEye;
                _collisionCheck.WallRayDir = _collisionCheck.WallRayOrigin == _leftEye ? new Vector2(-1, 0) : new Vector2(1, 0);
                _collisionCheck.GroundRayOrigin = _collisionCheck.GroundRayOrigin == _leftFoot ? _rightFoot : _leftFoot;
                _spriteRenderer.flipX = !_spriteRenderer.flipX;
            }
        }
        else
        {
            _rb2D.bodyType = RigidbodyType2D.Kinematic;
        }
    }

    private Vector2 MoveDir()
    {
        Vector2 moveDir;
        return moveDir = _collisionCheck.GroundRayOrigin == _leftFoot ? new Vector2(-1, 0) * _moveSpeed: new Vector2(1, 0) * _moveSpeed;
    }
}
