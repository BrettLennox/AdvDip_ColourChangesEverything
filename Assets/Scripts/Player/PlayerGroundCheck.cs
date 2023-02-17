using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGroundCheck : GroundCheck
{
    // Start is called before the first frame update
    private void FixedUpdate()
    {
        base.GroundCollisionCheck();
    }
}
