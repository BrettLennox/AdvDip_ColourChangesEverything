using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointManager : MonoBehaviour
{
    public static CheckpointManager instance;

    #region Variables
    [SerializeField] private Transform _checkpointParent;
    [SerializeField] private List<Transform> _checkpoints;
    [SerializeField] private int _checkpointIndex;
    #endregion
    #region Properties
    public int SetCheckpointIndex { set => _checkpointIndex = value; }
    #endregion

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        foreach(Transform checkpoint in _checkpointParent)
        {
            if(checkpoint.tag == "Checkpoint")
            {
                _checkpoints.Add(checkpoint);
                checkpoint.GetComponent<Checkpoint>().CheckpointIndex = _checkpoints.Count - 1;
                if(_checkpoints.Count == 1)
                {
                    checkpoint.GetComponent<Collider2D>().enabled = false;
                }
            }
        }
    }

    public Transform ReturnCurrentCheckpoint()
    {
        return _checkpoints[_checkpointIndex];
    }
}
