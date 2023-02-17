using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GroundCheck : MonoBehaviour
{
    #region Variables
    [Header("Ground Collision")]
    public Transform groundRayOrigin;
    public Vector2 groundRayDir;
    public float groundRayDistance;
    public LayerMask groundLayer;
    public bool isGrounded;
    #endregion
    #region Properties
    public Transform GroundRayOrigin { get => groundRayOrigin; set => groundRayOrigin = value; }
    public Vector2 RayDir { get => groundRayDir; set => groundRayDir = value; }
    public bool IsGrounded { get => isGrounded; }
    public LayerMask GroundLayer { get => groundLayer; }
    #endregion

    public virtual void GroundCollisionCheck()
    {
        isGrounded = RayCastCheck(groundRayOrigin.position, groundRayDir, groundRayDistance, groundLayer) ? true : false;
    }

    public virtual RaycastHit2D RayCastCheck(Vector2 origin, Vector2 rayDirection, float rayDistance, LayerMask layerMask)
    {
        RaycastHit2D hit = Physics2D.Raycast(origin, rayDirection, rayDistance, layerMask);
        
        return hit;
    }
}
