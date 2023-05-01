using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitGame : MonoBehaviour
{
    public void ExitGame(){
        #if UNITY_EDITOR
        UnityEditorApplication.isPlaying = false;
        #else
        Application.Quit();
        #endif
    }
}
