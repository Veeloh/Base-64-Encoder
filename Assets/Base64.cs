using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Base64 : MonoBehaviour
{
    public string playerInput;
    public string Output;

    public TMP_InputField input;
    public TMP_InputField OutputExit;

    public static string Base64Encode(string plainText)
    {
        var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
        return System.Convert.ToBase64String(plainTextBytes);
    }

    public static string Base64Decode(string base64EncodedData)
    {
        var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
        return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
    }

    public void Encode()
    {
        Output = Base64Encode(playerInput);
        Debug.Log(Output);
    }

    public void Decode()
    {
        Output = Base64Decode(playerInput);
        Debug.Log(Output);
    }

    public void Update()
    {
        playerInput = input.text;
        OutputExit.text = Output;
    }
}
