using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(GroundCheck))]
public class PlayerJump : MonoBehaviour
{
    #region Variables
    [SerializeField] private Rigidbody2D _rb;
    [SerializeField] [Range(10,100)] private float _jumpMultiplier;
    private float _hiddenJumpMultiplier;
    private GroundCheck _groundCheck;
    #endregion
    #region Properties

    #endregion

    private void Awake()
    {
        _groundCheck = GetComponent<GroundCheck>();
    }

    // Update is called once per frame
    void Update()
    {
        _hiddenJumpMultiplier = _jumpMultiplier * 10;

        if (Input.GetKeyDown(KeyCode.Space) && _groundCheck.IsGrounded)
        {
            _rb.AddForce(Vector2.up * _hiddenJumpMultiplier, ForceMode2D.Force);
        }
    }
}
