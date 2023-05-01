using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuList : MonoBehaviour
{
    public GameObject menuList;

    [SerializeField] private bool menuKeys = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(menuKeys){
            if(Input.GetKeyDown(KeyCode.Escape)){
            menuList.SetActive(true); 
            menuKeys = false;
            Time.timeScale = 0; //stop time
            }
        }
        else if(Input.GetKeyDown(KeyCode.Escape)){
            menuList.SetActive(false); 
            menuKeys = true;
            Time.timeScale = 1; // start time
        }
    }
    public void Back(){
        menuList.SetActive(false); 
        menuKeys = true;
        Time.timeScale = 1; // start time
    }
    public void Restart(){
        SceneManager.LoadScene(0);
    }
}
