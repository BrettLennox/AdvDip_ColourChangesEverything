using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldObjectsCycleDisplay : CycleDisplay
{
    #region Variables
    [SerializeField] private Collider2D _collider;
    #endregion

    // Update is called once per frame
    void Update()
    {
        base.CycleSpriteRenderer();
        _collider.enabled = ObjectColour == ChooseColour.instance.ChosenColour ? true : false;
    }
}
