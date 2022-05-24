using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class コイン : MonoBehaviour
{
    // Start is called before the first frame update
    public GameManager gameManager;
   private void Start()
    {
        GameObject gameManagerObject = GameObject.Find("GameManager");
        gameManager = gameManagerObject.GetComponent<GameManager>();
    }

    
    
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            gameManager.AddCoinCount();

        Destroy(gameObject);
         }
    }
}
