using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Yoystick : MonoBehaviour
{

    public RectTransform joyStickParent;
    public RectTransform joyStick;
    public float radius;
   
    void Update()
    {
        Touch nearTouch;
        for (int i = 0; i < Input.touchCount; i++)
        {
            Touch temp = Input.GetTouch(i);
            if (Vector3.Distance(joyStickParent.position, temp.position) < radius)
            {
                nearTouch = temp;   
                joyStick.position = nearTouch.position;
                Vector2 direction = temp.position - (Vector2)joyStickParent.position;
                direction.Normalize();
                Debug.Log(direction);
                
            }
        }
    }
}
