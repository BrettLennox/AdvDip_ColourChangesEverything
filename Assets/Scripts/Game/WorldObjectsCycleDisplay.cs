using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldObjectsCycleDisplay : CycleDisplay
{
    #region Variables
    [SerializeField] private Collider2D _collider;
    [SerializeField] private Animator _anim;
    #endregion

    // Update is called once per frame
    void Update()
    {
        base.CycleSpriteRenderer();
        _collider.enabled = ObjectColour == ChooseColour.instance.ChosenColour ? true : false;
        if(_anim != null)
        {
            bool colourMatch = ObjectColour == ChooseColour.instance.ChosenColour ? true : false;
            _anim.SetBool("ColourMatch", colourMatch);
        }
    }
}
