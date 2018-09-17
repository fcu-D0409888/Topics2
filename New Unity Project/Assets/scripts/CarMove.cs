using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;

public class CarMove : MonoBehaviour
{

    SerialPort sp = new SerialPort("COM5", 9600);
    // Use this for initialization 
    void Start()
    {
        sp.Open();
        sp.ReadTimeout = 100;
    }

    // Update is called once per frame 
    void Update()
    {
        if (sp.IsOpen)
        {
            try
            {
                if (sp.ReadByte() == 1)
                {
                    transform.Rotate(Vector3.up * Time.deltaTime * 100);
                    print("R");
                    // transform.Translate(Vector3.up*Time.deltaTime*100); 
                }
                else if (sp.ReadByte() == 2)
                {
                    transform.Rotate(Vector3.down * Time.deltaTime * 100);
                    print("L");
                    //transform.Translate(Vector3.down*Time.deltaTime*100); 
                }
            }
            catch (System.Exception)
            {
            }
        }
    }
}