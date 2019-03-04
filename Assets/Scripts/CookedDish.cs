using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CookedDish : MonoBehaviour {

    private float scaleX, scaleY;
   

    private void Start()
    {
        
        scaleX = GetComponent<Transform>().localScale.x;
        scaleY = GetComponent<Transform>().localScale.y;
    }

    private void OnMouseDown()
    {
        transform.localScale = new Vector2(scaleX * 1.5f, scaleY * 1.5f);
        
    }

    private void OnMouseUp()
    {
        transform.localScale = new Vector2(scaleX, scaleY);
        
    }
}
