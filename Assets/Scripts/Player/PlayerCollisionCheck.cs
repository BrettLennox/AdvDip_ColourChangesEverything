using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisionCheck : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        bool enemy = collision.gameObject.CompareTag("Enemy");

        if (enemy)
        {
            transform.position = CheckpointManager.instance.ReturnCurrentCheckpoint().position;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        bool checkpoint = collision.gameObject.CompareTag("Checkpoint");

        if (checkpoint)
        {
            CheckpointManager.instance.SetCheckpointIndex = collision.GetComponent<Checkpoint>().CheckpointIndex;
            collision.GetComponent<Collider2D>().enabled = false;
        }
    }
}
