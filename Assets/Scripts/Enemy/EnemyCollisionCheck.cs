using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollisionCheck : GroundCheck
{
    #region Variables
    [Header("Wall Collision")]
    [SerializeField] private Transform _wallRayOrigin;
    [SerializeField] private Vector2 _wallRayDir;
    [SerializeField] private float _wallRayDistance;
    [SerializeField] private bool _hitWall = false;
    #endregion
    #region Properties
    public Transform WallRayOrigin { get => _wallRayOrigin; set => _wallRayOrigin = value; }
    public Vector2 WallRayDir { get => _wallRayDir; set => _wallRayDir = value; }
    public float WallRayDistance { get => _wallRayDistance; }
    public bool HitWall { get => _hitWall; }
    #endregion
    private void FixedUpdate()
    {
        base.GroundCollisionCheck();
        WallCollisionCheck();
    }

    private void WallCollisionCheck()
    {
        _hitWall = base.RayCastCheck(_wallRayOrigin.position, _wallRayDir, _wallRayDistance, GroundLayer);
    }
}
