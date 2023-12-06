using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelMgr : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadLevel(string nameScene) 
    {
        SceneManager.LoadScene(nameScene);
    }

    public void Exit()
    {
        Debug.Log("Out Game...");
        Application.Quit();
    }
}
