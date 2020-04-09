using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using TMPro;
using System.Collections.Generic;

public class MessageBoard : MonoBehaviour
{
    //private string messagePath = Application.persistentDataPath + "/messageBoard.txt";
    public MessageBoardData messageDict;
    private TextMeshProUGUI textmp;
    private float startTime;
    private List<float> timestamps;

    private void Start()
    {
        startTime = Time.time;
        timestamps = new List<float>();
        messageDict = new MessageBoardData();
        textmp = GetComponent<TextMeshProUGUI>();
        LoadMessages();
        string path = Application.persistentDataPath + "/messageBoard.txt";

        if (File.Exists(path))
        {
            StreamReader sr = new StreamReader(path);
            var fileContents = sr.ReadToEnd();
            sr.Close();
            var lines = fileContents.Split("\n"[0]);
            foreach (var line in lines)
            {
                var sects = line.Split("\t"[0]);
                messageDict.messageDict.Add(float.Parse(sects[0]), sects[1]);
                timestamps.Add(float.Parse(sects[0]));
            }
            //textmp.text += "\n" + messageDict.ToString();
        }
        else
        {
            Debug.LogError("Message Board file not found in " + path);
        }
    }

    private void Update()
    {
        if (timestamps.Count > 0)
        {
            if (Time.time - startTime >= timestamps[0])
            {
                textmp.text += "\n[" + timestamps[0] + "]: " + messageDict.messageDict[timestamps[0]];
                timestamps.Remove(timestamps[0]);
            }
        }
    }

    public static void LoadMessages()
    {


    }
}