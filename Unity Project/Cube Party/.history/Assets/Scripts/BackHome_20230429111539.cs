using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SceneManagement;

public class BackHome : MonoBehaviour
{
    public void BackToHome(){
        SceneManager.LoadScene(0);
    }
}
