using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

class helpers
    {

    public static void GUIDrawRect(Rect position, Color color)
    {
        Texture2D _staticRectTexture = null;
        GUIStyle _staticRectStyle = null;

        if (_staticRectTexture == null)
        {
            _staticRectTexture = new Texture2D(1, 1);
        }

        if (_staticRectStyle == null)
        {
            _staticRectStyle = new GUIStyle();
        }

        _staticRectTexture.SetPixel(0, 0, color);
        _staticRectTexture.Apply();

        _staticRectStyle.normal.background = _staticRectTexture;

        GUI.Box(position, GUIContent.none, _staticRectStyle);


    }
}
