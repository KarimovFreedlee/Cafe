using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharManager : MonoBehaviour {
    private float x;
    public Sprite prefabOne, prefabTwo, prefabThree, prefabFourth;
    private SpriteRenderer CurrentSprite;
    private Sprite[] sprites;
    public GameObject HotDog, Burger, Cola;
    private GameObject[] Orders;
    private int ordersAmount;
    public static GameObject orderOne, orderTwo, orderThree;
    // Use this for initialization
    void Start () {

        x = GetComponent<Transform>().position.x;
        CurrentSprite = GetComponent<SpriteRenderer>();
        sprites = new Sprite[4] { prefabOne, prefabTwo, prefabThree, prefabFourth };
        CurrentSprite.sprite = sprites[Random.Range(0, 4)];
        Orders = new GameObject[3] { HotDog, Burger, Cola };
        ordersAmount = Random.Range(1, 4);
        OrderCreate();
    }
	
	// Update is called once per frame
	void Update ()
    {
	    if(Orders==null)
        {
            Destroy(gameObject);
        }
	}
    private void OnEnable()
    {
        StartCoroutine(CharDestroy()); 
        
    }

    private void OnDestroy()
    {
       
        if(x == -4f)
        {
            GameManager.positionOne = true;
        }
        else if (x == -0.7f)
        {
            
            GameManager.positionTwo = true;
        }
        else if (x == 2.2f)
        {
            
            GameManager.positionThree = true;
        }
        else if (x == 5.2f)
        {
            
            GameManager.positionFourth = true;
        }
        
    }

    private  void OrderCreate()
    {
        switch (ordersAmount)
        {
            case 1:
                 orderOne = Instantiate(Orders[Random.Range(0, 3)], new Vector2(GetComponent<Transform>().position.x - 1.5f, GetComponent<Transform>().position.y), Quaternion.identity);
                
                break;
            case 2:
                orderOne = Instantiate(Orders[Random.Range(0, 3)], new Vector2(GetComponent<Transform>().position.x - 1.5f, GetComponent<Transform>().position.y + 0.5f), Quaternion.identity);
                orderTwo = Instantiate(Orders[Random.Range(0, 3)], new Vector2(GetComponent<Transform>().position.x - 1.5f, GetComponent<Transform>().position.y - 0.5f), Quaternion.identity);
                
                break;
            case 3:
                orderOne = Instantiate(Orders[Random.Range(0, 3)], new Vector2(GetComponent<Transform>().position.x - 1.5f, GetComponent<Transform>().position.y - 0.8f), Quaternion.identity);
                orderTwo = Instantiate(Orders[Random.Range(0, 3)], new Vector2(GetComponent<Transform>().position.x - 1.5f, GetComponent<Transform>().position.y), Quaternion.identity);
                orderThree = Instantiate(Orders[Random.Range(0, 3)], new Vector2(GetComponent<Transform>().position.x - 1.5f, GetComponent<Transform>().position.y + 0.8f), Quaternion.identity);
                
                break;
        }
    }

    public void OrderCheck()
    {

    }

    IEnumerator CharDestroy()
    {
       
        yield return new WaitForSeconds(18f);
        Destroy(gameObject);
    }

    
}
