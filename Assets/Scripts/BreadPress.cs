using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreadPress : MonoBehaviour {
    private float scaleX, scaleY;
    public static bool firstPlate = true, secondPlate = true, thirdPlate = true;
    public GameObject Prefab;
   
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
        if(firstPlate)
        {
            Instantiate(Prefab, new Vector2(GetComponent<Transform>().position.x + 0.2f, -2.5f), Quaternion.identity);
            firstPlate = false;
        }
        else if (secondPlate)
        {
            Instantiate(Prefab, new Vector2(GetComponent<Transform>().position.x, -1.5f), Quaternion.identity);
            secondPlate = false;
        }
        else if (thirdPlate)
        {
            Instantiate(Prefab, new Vector2(GetComponent<Transform>().position.x-0.2f , -0.5f), Quaternion.identity);
            thirdPlate = false;
        }

    }
}
