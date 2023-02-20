using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    #region Variables
    [SerializeField] private int _checkpointIndex;
    #endregion
    #region Properties
    public int CheckpointIndex { get => _checkpointIndex; set => _checkpointIndex = value; }
    #endregion

    private void Start()
    {
        if(_checkpointIndex == 0)
        {
            GetComponent<Collider2D>().enabled = false;
        }
    }
}
