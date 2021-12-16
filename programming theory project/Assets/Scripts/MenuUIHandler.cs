using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

#if UNITY_EDITOR
using UnityEditor;
#endif

public class MenuUIHandler : MonoBehaviour
{
    public void StartApp()
    {
        SceneManager.LoadScene(1);
    }

    public void ExitApp()
    {
    #if UNITY_EDITOR
                        EditorApplication.ExitPlaymode();
    #else
        Application.Quit();
    #endif
    }
}
