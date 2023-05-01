using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class finishLineControl : MonoBehaviour
{
    public GameObject EndMenuList;
    //[SerializeField] private bool EmenuKeys = true;

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
            EndMenuList.SetActive(true); 
            //EmenuKeys = false;
            Time.timeScale = 0; //stop time
        }
    }

    private void OnTriggerStay(Collider other)
    {
        
    }

    private void OnTriggerExit(Collider other)
    {
        
    }

    public void NextLevel(){
        int i= SceneManager.GetActiveScene().buildIndex;
        if (i<= 2){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
            Time.timeScale = 1;
            }
            else {
                SceneManager.LoadScene(3);
            }
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
        
        //SceneManager.LoadScene(0);
        //Time.timeScale = 1; // start time
    }

    public void BackToStartScene(){
        EndMenuList.SetActive(false); 
        //EmenuKeys = true;
        Time.timeScale = 1; // start time
        SceneManager.LoadScene(0);
    }
}
