using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public int coinCount;
    public void Start()
    {
        coinCount = 0;
    }

    public void SeneReset()
    {
        string activeSceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(activeSceneName);
    }
    public void changeScene(string nextScene)
    {
        SceneManager.LoadScene(nextScene);
    }
    public void AddCoinCount()
    {
        coinCount = coinCount + 1;
        Debug.Log("CoinCount:" + coinCount);

    }
}
