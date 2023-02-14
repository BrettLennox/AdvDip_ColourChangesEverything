using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayNextColour : MonoBehaviour
{
    #region Variables
    [SerializeField] private TextMeshProUGUI _text;
    #endregion

    private void Update()
    {
        switch (ChooseColour.instance.NewColour)
        {
            case Colours.Red:
                _text.color = Colour.instance.RedColour;
                break;
            case Colours.Green:
                _text.color = Colour.instance.GreenColour;
                break;
            case Colours.Yellow:
                _text.color = Colour.instance.YellowColour;
                break;
            case Colours.Blue:
                _text.color = Colour.instance.BlueColour;
                break;
        }
    }
}
