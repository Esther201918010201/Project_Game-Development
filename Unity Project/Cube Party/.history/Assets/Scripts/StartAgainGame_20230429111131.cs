using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartAgainGame : MonoBehaviour
{
    public void StartMenu(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
}
