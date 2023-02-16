using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseColour : MonoBehaviour
{
    public static ChooseColour instance;

    #region Variables
    [SerializeField] private Colours _chosenColour;
    [SerializeField] private Colours _newColour;
    [SerializeField] private bool _newColourChosen;
    [SerializeField] private float _timer = Mathf.Infinity;
    [SerializeField] private float _changeColourDelay = 2f;
    #endregion
    #region Properties
    public Colours ChosenColour { get => _chosenColour; }
    public Colours NewColour { get => _newColour; }
    #endregion

    private void Awake()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        if (_timer >= _changeColourDelay)
        {
            _chosenColour = _newColour;
            _newColourChosen = false;
            _timer = 0;
        }
        else
        {
            if (!_newColourChosen)
            {
                SelectRandomColour();
                if (_newColour == _chosenColour)
                {
                    SelectRandomColour();
                }
                else
                {
                    _newColourChosen = true;
                }
            }
            
        }
    }

    private void SelectRandomColour()
    {
        _newColour = (Colours)Random.Range(0, 4);
    }

    private void FixedUpdate()
    {
        _timer += Time.deltaTime;
    }
}
