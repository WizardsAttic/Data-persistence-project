using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using UnityEngine.UI;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class MenuUI : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        Debug.Log("test");
        DataHandler.Instance.playerName = GameObject.Find("PlayerNameInput").GetComponent<InputField>().text; //save the inputed name
        Debug.Log(DataHandler.Instance.playerName);
        SceneManager.LoadScene(1);
    }


    public void Exit()
    {
        //MainManager.Instance.SaveScore();
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
}
