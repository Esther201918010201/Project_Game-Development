using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class Follow : MonoBehaviour
{
    public GameObject objFollow;
    public float speed = 2.0f;
    public Vector3 offset = new Vector3(0,5,-10);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = Vector3.Lerp(this.transform.position, objFollow.transform.position + offset, speed * Time.deltaTime);
    }
}
