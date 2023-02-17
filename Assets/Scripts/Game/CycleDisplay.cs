using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CycleDisplay : MonoBehaviour
{
    #region Variables
    [SerializeField] Colours _objectColour;
    [SerializeField] private SpriteRenderer _spriteRenderer;
    #endregion
    #region Properties
    public Colours ObjectColour { get => _objectColour; }
    #endregion
    public virtual void CycleSpriteRenderer()
    {
        _spriteRenderer.color = _objectColour == ChooseColour.instance.ChosenColour ? Colour.instance.ReturnActiveColour(_objectColour) : Colour.instance.ReturnInactiveColour(_objectColour);
    }

    public  virtual bool ColourMatch()
    {
        return _objectColour == ChooseColour.instance.ChosenColour;
    }
}
