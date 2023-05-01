using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finishLineControl : MonoBehaviour
{
    public GameObject EndMenuList;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NextLevel(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }

    public void BackToStartScene(){
        EndMenuList.SetActive(false); 

        SceneManager.LoadScene(0);
    }

    private void OnTriggerEnter(Collider other) {
        GameObject finishLine = GameObject.Find("finishLine");
        if(finishLine != null){
            menuList.SetActive(true); 
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
