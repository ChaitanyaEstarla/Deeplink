using System;
using UnityEngine;

public class DisplayString : MonoBehaviour
{
    private void Start()
    {
        var stringManager = new StringManager("Blaze");
        Action showMethod = stringManager.DisplayToConsole;
        showMethod();
    }
}
