using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    #region Variables
    [SerializeField] private Animator _anim;
    [SerializeField] private bool _isMoving;
    [SerializeField] private bool _isGrounded;
    #endregion
    #region Properties
    public bool IsMoving { get => _isMoving; set => _isMoving = value; }
    public bool IsGrounded { get => _isGrounded; set => _isGrounded = value; }
    #endregion

    // Update is called once per frame
    void Update()
    {
        _anim.SetBool("IsMoving", _isMoving);
        _anim.SetBool("IsGrounded", _isGrounded);
    }
}
