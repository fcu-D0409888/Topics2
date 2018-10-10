using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SpeechLib;

public class UIController : MonoBehaviour
{

    public float RotateSpeed = 50f;
    public float DestroyTime = 5f;
    private bool touchCube = false;
    string word;
    int count = 0;
    int time_i = 0;
    float time_f = 0;
    int a = 0;
    // Use this for initialization
    void Start()
    {
        //Destroy(gameObject, DestroyTime);
        GameObject.Find("UI").SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void setBool()
    {
        touchCube = true;

    }
    void OnGUI()
    {

        if (touchCube == true)
        {

            time_f = Time.time;
            time_i = Mathf.FloorToInt(time_f);
            print("time :" + time_i);
            word = Rotate.temp;
            GUIStyle showLabelStytle = new GUIStyle(GUI.skin.label);
            showLabelStytle.fontSize = 80;
            GUI.color = Color.green;
            GUI.Label(new Rect(Screen.width / 2 - 200 / 2, Screen.height / 2 - 150 / 2 - 50, 300, 250), word, showLabelStytle);
            Debug.Log(count);
            if (a == 0)
            {
                Invoke("speak", 0.3f);
                a = 1;
            }
            count++;

            //GUI.Label(new Rect(Screen.width / 2 - 200 / 2, Screen.height / 2 - 150 / 2 - 50, 200, 150), " ", showLabelStytle);
        }
        
        if (count % 200 == 0)
        {
            touchCube = false;
            a = 0;
        }


    }

    void speak()
    {

        SpVoice v = new SpVoice();
        v.Voice = v.GetVoices(string.Empty, string.Empty).Item(0);
        v.Rate = 2;
        v.Speak(Rotate.temp);
       
        CancelInvoke("speak");
    }
}
