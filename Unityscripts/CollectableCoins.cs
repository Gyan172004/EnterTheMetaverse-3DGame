using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableCoins : MonoBehaviour
{  public int coin;
    // Start is called before the first frame update

    void Start()
    {

        
    }
public void OnTriggerEnter(Collider Col){


    // Update is called once per frame
    if(Col.gameObject.tag == "Coin"){
  Debug.Log("Coin collected");
  coin = coin +1;
  Col.gameObject.SetActive(false);
  Destroy(Col.gameObject);
    } 
}
    void Update()
    {
        
    }
}

