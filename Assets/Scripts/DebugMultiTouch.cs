using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DebugMultiTouch : MonoBehaviour
{
	public RectTransform rect;
    public int toque = 0;

	public TextMeshProUGUI text;
    void Update()
    {
		try
		{
			Touch touch = Input.GetTouch(toque);
			rect.position = touch.position;

			text.text = "Posicion: " + touch.position + "<br>" +
				"Delta: " + touch.deltaPosition + "<br>" +
				"Phase: " + touch.phase;
		}
		catch
		{

		}
    }
}
