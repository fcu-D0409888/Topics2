using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rotate : MonoBehaviour
{
    public float RotateSpeed = 50f;
    public float DestroyTime = 5f;
    // Use this for initialization
    public static string temp;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * Time.deltaTime * RotateSpeed, Space.World);
    }

    void OnTriggerEnter(Collider other)
    {
        int index = this.gameObject.transform.name.IndexOf("(Clone)");
        temp = this.gameObject.transform.name.Remove(index);
        
        ((UIController)GameObject.FindObjectOfType(typeof(UIController))).setBool();
        
        this.gameObject.SetActive(false);
        //print(touchCube);
        Debug.Log("gameobject:" + this.gameObject.ToString());
     
    }
}