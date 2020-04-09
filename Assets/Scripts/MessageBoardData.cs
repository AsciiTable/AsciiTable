using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class MessageBoardData{
    public Dictionary<float, string> messageDict = new Dictionary<float, string>();

    public override string ToString()
    {
        string messages = "";
        foreach (KeyValuePair<float, string> message in messageDict) {
            messages = messages + "[" + message.Key + "]: " + message.Value + "\n";
        }
        return messages;
    }

}
