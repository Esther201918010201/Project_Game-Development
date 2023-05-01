using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndingMenuList : MonoBehaviour
{
    public GameObject menuList;
    [SerializeField] private bool menuKeys = true;

    // Update is called once per frame
    void Update()
    {

    }

    public void NextLevel(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }

    public void BackToStartScene(){
        SceneManager.LoadScene(0);
    }
}
