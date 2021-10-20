using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnReturnClick()
    {
        SceneManager.LoadScene("MenuScene");
    }
    public void OnRestartClick()
    {
        SceneManager.LoadScene("GameScene");
    }
    public void OnStartClick()
    {
        SceneManager.LoadScene("GameScene");
    }
}
