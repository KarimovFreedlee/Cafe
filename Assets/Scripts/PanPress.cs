using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanPress : MonoBehaviour {

    private float scaleX, scaleY;
    private SpriteRenderer CurrentSprite;
    public GameObject Meat, MeatTimer;
    public Sprite prefabOne, prefabTwo;

    private void Start()
    {
       
        scaleX = GetComponent<Transform>().localScale.x;
        scaleY = GetComponent<Transform>().localScale.y;
        CurrentSprite = Meat.GetComponent<SpriteRenderer>();
        
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
