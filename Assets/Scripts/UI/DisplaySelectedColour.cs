using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class DisplaySelectedColour : MonoBehaviour
{
    #region Variables
    [SerializeField] Colours _objectColour;
    [SerializeField] private Image _image;
    #endregion
    #region Properties
    public Colours ObjectColour { get => _objectColour; }
    #endregion

    private void Update()
    {
        CycleSpriteRenderer();
    }

    private void CycleSpriteRenderer()
    {
        _image.color = _objectColour == ChooseColour.instance.ChosenColour ? Colour.instance.ReturnActiveColour(_objectColour) : Colour.instance.ReturnInactiveColour(_objectColour);
    }
}
