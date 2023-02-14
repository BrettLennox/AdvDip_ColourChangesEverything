using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    #region Variables
    [SerializeField] private float _speed = 1f;
    [SerializeField] private Vector2 _moveDir;
    [SerializeField] private float _smoothStep;
    #endregion
    #region Properties

    #endregion

    // Update is called once per frame
    void Update()
    {
        transform.Translate(CalculateMovement(_moveDir) * Time.deltaTime * _speed);
    }

    private Vector2 CalculateMovement(Vector2 moveDirection)
    {
        moveDirection.x = Input.GetKey(KeyCode.A) ? -1 : Input.GetKey(KeyCode.D) ? 1 : 0;

        return moveDirection;
    }
}
