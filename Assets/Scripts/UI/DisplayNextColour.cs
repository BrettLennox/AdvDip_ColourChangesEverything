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
        _text.color = Colour.instance.ReturnActiveColour(ChooseColour.instance.NewColour);
    }
}
