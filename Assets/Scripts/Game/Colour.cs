using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colour : MonoBehaviour
{
    public static Colour instance;

    #region Variables
    [SerializeField] private Color _redColour, _redInactiveColour, _greenColour, _greenInactiveColour, _yellowColour, _yellowInactiveColour, _blueColour, _blueInactiveColour;
    #endregion
    #region Properties
    public Color RedColour { get => _redColour; }
    public Color RedInactiveColour { get => _redInactiveColour; }
    public Color GreenColour { get => _greenColour; }
    public Color GreenInactiveColour { get => _greenInactiveColour; }
    public Color YellowColour { get => _yellowColour; }
    public Color YellowInactiveColour { get => _yellowInactiveColour; }
    public Color BlueColour { get => _blueColour; }
    public Color BlueInactiveColour { get => _blueInactiveColour; }
    #endregion

    private void Awake()
    {
        instance = this;
    }

    public Color ReturnActiveColour(Colours colour)
    {
        Color tempActiveColour = Color.black;
        switch (colour)
        {
            case Colours.Red:
                tempActiveColour = _redColour;
                break;
            case Colours.Green:
                tempActiveColour = _greenColour;
                break;
            case Colours.Yellow:
                tempActiveColour = _yellowColour;
                break;
            case Colours.Blue:
                tempActiveColour = _blueColour;
                break;
        }
        return tempActiveColour;
    }

    public Color ReturnInactiveColour(Colours colour)
    {
        Color tempInactiveColour = Color.black;
        switch (colour)
        {
            case Colours.Red:
                tempInactiveColour = _redInactiveColour;
                break;
            case Colours.Green:
                tempInactiveColour = _greenInactiveColour;
                break;
            case Colours.Yellow:
                tempInactiveColour = _yellowInactiveColour;
                break;
            case Colours.Blue:
                tempInactiveColour = _blueInactiveColour;
                break;
        }
        return tempInactiveColour;
    }
}
public enum Colours
{
    Red,
    Green,
    Yellow,
    Blue
}
