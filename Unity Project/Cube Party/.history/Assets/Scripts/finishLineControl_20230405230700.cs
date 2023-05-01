using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finishLineControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) {
        GameObject finishLine = GameObject.Find("finishLine");
        if(finishLine != null){
            menuList.SetActive(true); 
            menuKeys = false;
            Time.timeScale = 0; //stop time
        }
    }

    private void OnTriggerStay(Collider other)
    {
        
    }

    private void OnTriggerExit(Collider other)
    {
        
    }
}
