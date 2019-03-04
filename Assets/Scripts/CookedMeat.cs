using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CookedMeat : MonoBehaviour {
    private float scaleX, scaleY;

    public delegate void ClickAction();
    public static event ClickAction OnClick;

    private void OnEnable()
    {
       
    }

    private void OnDisable()
    {
        
    }

    private void OnMouseDown()
    {
        transform.localScale = new Vector2(scaleX * 1.5f, scaleY * 1.5f);
    }

    private void OnMouseUp()
    {
        transform.localScale = new Vector2(scaleX, scaleY);
        if(BreadPress.firstPlate == false)
        {

        }
        else if (BreadPress.secondPlate == false)
        {

        }
        else if (BreadPress.secondPlate == false)
        {

        }
    }

   

}
