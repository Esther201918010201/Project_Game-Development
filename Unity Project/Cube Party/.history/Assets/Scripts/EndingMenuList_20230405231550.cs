using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndingMenuList : MonoBehaviour
{
    public GameObject EndMenuList;

    // Update is called once per frame
    void Update()
    {

    }

    public void NextLevel(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }

    public void BackToStartScene(){
        EndMenuList.SetActive(false); 
        menuKeys = true;
        SceneManager.LoadScene(0);
    }
}
