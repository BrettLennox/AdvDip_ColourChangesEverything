using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseColour : MonoBehaviour
{
    public static ChooseColour instance;

    #region Variables
    [SerializeField] private Colours _chosenColour;
    //[SerializeField] private Colours _newColour;
    //[SerializeField] private bool _newColourChosen;
    //[SerializeField] private float _timer = Mathf.Infinity;
    //[SerializeField] private float _changeColourDelay = 2f;
    #endregion
    #region Properties
    public Colours ChosenColour { get => _chosenColour; }
    //public Colours NewColour { get => _newColour; }
    #endregion

    private void Awake()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SetColour(Colours.Red);
        }
        if (Input.GetMouseButtonDown(1))
        {
            SetColour( Colours.Yellow);
        }
        //if (Input.GetKeyDown(KeyCode.Alpha3))
        //{
        //    SetColour(Colours.Green);
        //}
        //if (Input.GetKeyDown(KeyCode.Alpha4))
        //{
        //    SetColour(Colours.Blue);
        //}
    }

    private void SetColour(Colours colour)
    {
        _chosenColour = colour;
    }
}
