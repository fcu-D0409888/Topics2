using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LitJson;
using System.IO;
using System.Linq;

public class SpawnItem : MonoBehaviour
{
    public Transform[] SpawnPoints;//生成一個座標物件
    public float spawnTime = 2.5f;//多久生成
    public GameObject Items;
    private string jsonString;
    private JsonData jsonData;
    private string temp;
    private int[] noiseValues;
    int count = 0;

    // Use this for initialization
    void Start()
    {
        jsonString = File.ReadAllText(Application.dataPath + "/json/test.json");//(1)
        jsonData = JsonMapper.ToObject(jsonString);//(2)
                                                   //Random.InitState((int)System.DateTime.Now.Ticks);

        InvokeRepeating("SpawnItems", spawnTime, spawnTime);//2.5秒生成物件，然後每2.5秒後生成一次物件
                                                            //在特定段時間內重複呼叫SpawnItem方法
    }
    // Update is called once per frame
    void Update()
    {

    }
    // SpawnItems負責隨機生成物件
    void SpawnItems()
    {
        int i = Random.Range(0, 3);

        temp = jsonData["id"][i]["ename"].ToString();

        ////int spawnIndex = Random.Range(0, SpawnPoints.Length);
        //int spawnIndex = Random.Range(0, 5);
        // print("spawnIndex:" + spawnIndex);
      
        if (count < 5)
        {
            int spawnIndex = UniqueRandomInt(0, 5);
            print("spawnIndex:" + spawnIndex);
            Items = Resources.Load<GameObject>(temp);
            Instantiate(Items, SpawnPoints[spawnIndex].position, SpawnPoints[spawnIndex].rotation);
        }

        count++;
    }
    List<int> usedValues = new List<int>();
    public int UniqueRandomInt(int min, int max)
    {
        int val = Random.Range(min, max);
        while (usedValues.Contains(val))
        {
            val = Random.Range(min, max);
        }
        usedValues.Add(val);
        return val;
    }
}