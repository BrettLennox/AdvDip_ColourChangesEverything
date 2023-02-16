using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;
    [SerializeField] private Transform _leftFoot, _rightFoot;
    [SerializeField] private Rigidbody2D _rb2D;

    [SerializeField] private GroundCheck _groundCheck;
    [SerializeField] private CycleDisplay _cycleDisplay;

    // Start is called before the first frame update
    void Awake()
    {
        _cycleDisplay = GetComponent<CycleDisplay>();
    }

    private void Start()
    {
        _groundCheck.RayOrigin = _leftFoot;
    }

    // Update is called once per frame
    void Update()
    {
        if (_cycleDisplay.ColourMatch())
        {
            _rb2D.bodyType = RigidbodyType2D.Dynamic;
            transform.Translate(MoveDir() * Time.deltaTime);

            if (!_groundCheck.IsGrounded)
            {
                _groundCheck.RayOrigin = _groundCheck.RayOrigin == _leftFoot ? _rightFoot : _leftFoot;
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
        return moveDir = _groundCheck.RayOrigin == _leftFoot ? new Vector2(-1, 0) * _moveSpeed: new Vector2(1, 0) * _moveSpeed;
    }
}
