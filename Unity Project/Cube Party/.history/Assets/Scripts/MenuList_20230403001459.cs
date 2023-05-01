using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
            }
        }
        else if(Input.GetKeyDown(KeyCode.Escape)){
            menuList.SetActive(false); 
            menuKeys = true;
        }
    }
}
