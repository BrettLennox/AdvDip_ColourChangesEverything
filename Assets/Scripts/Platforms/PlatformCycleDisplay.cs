using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class PlatformCycleDisplay : MonoBehaviour
{
    #region Variables
    [SerializeField] private Tilemap _tilemap;
    [SerializeField] Colours _objectColour;
    [SerializeField] private Collider2D _collider;
    #endregion

    // Update is called once per frame
    void Update()
    {
        CycleSpriteRenderer();
        _collider.enabled = _objectColour == ChooseColour.instance.ChosenColour ? true : false;
    }

    private void CycleSpriteRenderer()
    {
        _tilemap.color = _objectColour == ChooseColour.instance.ChosenColour ? Colour.instance.ReturnActiveColour(_objectColour) : Colour.instance.ReturnInactiveColour(_objectColour);
    }
}
