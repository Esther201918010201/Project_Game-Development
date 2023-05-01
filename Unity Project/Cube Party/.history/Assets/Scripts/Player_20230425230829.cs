using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //horizontal
        float horizontal = Input.GetAxis("Horizontal");
        //vertical
        float vertical = Input.GetAxis("Vertical");
        //Vector3
        Vector3 dir = new Vector3(vertical, 0, horizontal);
        //面向向量
        //transform.rotation = Quaternion.LookRotation(dir);
        //当用户按下方向键
        if (dir != Vector3.zero){
            transform.rotation = Quaternion.LookRotation(dir);
            animator.SetBool("isRun",true);//播放跑步动画
            //朝前移动
            transform.Translate(Vector3.back*1*Time.deltaTime);
        }if (Input.GetKeyDown(KeyCode.Space)){
            transform.Translate(Vector3.up*50*Time.deltaTime);
        }else
        {
            animator.SetBool("isRun",false);//播放站立动画
        }
    }
}