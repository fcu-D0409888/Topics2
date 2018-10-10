using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LitJson;
using System.IO;

public class JSONTest : MonoBehaviour
{
    private string jsonString;
    private JsonData jsonData;

    // Use this for initialization
    void Start()
    {
        jsonString = File.ReadAllText(Application.dataPath + "/json/test.json");//(1)
        jsonData = JsonMapper.ToObject(jsonString);//(2)

        int i = Random.Range(0, 3);

        Debug.Log(jsonData["id"][i]["cname"] + ":" + jsonData["id"][i]["ename"]);

    }

}
