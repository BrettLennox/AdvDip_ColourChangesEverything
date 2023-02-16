using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    #region Variables
    [SerializeField] private float _rayDistance;
    [SerializeField] private Vector2 _rayDir;
    [SerializeField] private LayerMask _groundLayer;
    [SerializeField] private bool _isGrounded;
    #endregion
    #region Properties
    public bool IsGrounded { get => _isGrounded; }
    #endregion

    // Update is called once per frame
    void Update()
    {
        _isGrounded = RayCastCheck(_rayDir, _rayDistance, _groundLayer) ? true : false;
    }

    private RaycastHit2D RayCastCheck(Vector2 rayDirection, float rayDistance, LayerMask groundLayerMask)
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, rayDirection, rayDistance, groundLayerMask);

        return hit;
    }
}
