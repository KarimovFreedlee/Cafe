using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public GameObject Char;
    public static bool positionOne = true, positionTwo = true, positionThree = true, positionFourth = true;

    

    // Use this for initialization
    void Start () {
        StartCoroutine(CreateChar());
	}

    IEnumerator CreateChar()
    {
        while (true)
        {
            
            if (positionOne)
            {
                PositionChar(-4f, 1.6f);
                positionOne = false;
            }
            else if(positionTwo)
            {
                PositionChar(-0.7f, 1.6f);
                positionTwo = false;
            }
            else if(positionThree)
            {
                PositionChar(2.2f, 1.6f);
                positionThree = false;
            }
            else if(positionFourth)
            {
                PositionChar(5.2f, 1.6f);
                positionFourth = false;
            }
            yield return new WaitForSeconds(3f);
        }
    }

    private void PositionChar(float x, float y)
    {
        
        Instantiate(Char, new Vector3(x, y, 80f), Quaternion.identity);
        
    }
}
