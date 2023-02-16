using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CycleDisplay : MonoBehaviour
{
    #region Variables
    [SerializeField] Colours _objectColour;
    [SerializeField] private SpriteRenderer _spriteRenderer;
    [SerializeField] private Collider2D _collider;
    #endregion
    #region Properties
    public Colours ObjectColour { get => _objectColour; }
    #endregion
    // Update is called once per frame
    void Update()
    {
        _spriteRenderer.color = _objectColour == ChooseColour.instance.ChosenColour ? Colour.instance.ReturnActiveColour(_objectColour) : Colour.instance.ReturnInactiveColour(_objectColour);
        _collider.enabled = _objectColour == ChooseColour.instance.ChosenColour ? true : false;
    }

    public bool ColourMatch()
    {
        return _objectColour == ChooseColour.instance.ChosenColour;
    }
}
