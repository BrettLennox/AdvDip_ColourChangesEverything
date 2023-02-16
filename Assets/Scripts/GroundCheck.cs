using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    #region Variables
    [SerializeField] private Transform _rayOrigin;
    [SerializeField] private Vector2 _rayDir;
    [SerializeField] private float _rayDistance;
    [SerializeField] private LayerMask _groundLayer;
    [SerializeField] private bool _isGrounded;
    #endregion
    #region Properties
    public Transform RayOrigin { get => _rayOrigin; set => _rayOrigin = value; }
    public Vector2 RayDir { get => _rayDir; set => _rayDir = value; }
    public bool IsGrounded { get => _isGrounded; }
    #endregion

    // Update is called once per frame
    void FixedUpdate()
    {
        _isGrounded = RayCastCheck(_rayOrigin.position, _rayDir, _rayDistance, _groundLayer) ? true : false;
    }

    private RaycastHit2D RayCastCheck(Vector2 origin, Vector2 rayDirection, float rayDistance, LayerMask groundLayerMask)
    {
        RaycastHit2D hit = Physics2D.Raycast(origin, rayDirection, rayDistance, groundLayerMask);
        
        return hit;
    }
}
