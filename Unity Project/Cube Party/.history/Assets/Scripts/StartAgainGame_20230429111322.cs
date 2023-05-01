using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartAgainGame : MonoBehaviour
{
    public void BackHome(){
        SceneManager.LoadScene(0);
    }
}
