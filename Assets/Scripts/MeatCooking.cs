using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeatCooking : MonoBehaviour {
    public GameObject MeatPrefab;
    

	// Use this for initialization
	void OnEnable () {

        StartCoroutine(Cooking());

    }
	
	IEnumerator Cooking()
    {  
        yield return new WaitForSeconds(7f);
        Destroy(gameObject);
        Instantiate(MeatPrefab, new Vector2(GetComponent<Transform>().position.x, GetComponent<Transform>().position.y), Quaternion.identity);
    }

    
}
