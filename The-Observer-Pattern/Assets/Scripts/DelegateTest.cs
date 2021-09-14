using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelegateTest : MonoBehaviour
{
    private delegate void Print(string val);
    private Print _p;

    private void Awake()
    { 
        _p = PrintValue;
        _p += PrintData;
    }

    private void Start()
    {
        _p("DelegateTest");
    }

    private static void PrintData(string s)
    {
        Debug.Log("PrintData " + s);
    }

    private static void PrintValue(string s)
    {
        Debug.Log("PrintValue " + s);
    }
}
