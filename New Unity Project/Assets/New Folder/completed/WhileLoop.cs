using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhileLoop : MonoBehaviour
{
    int cupsIntheSink = 4;
    void Start()
    {
        while(cupsIntheSink > 0)
        {
            Debug.Log("I've washed a cup!");
            cupsIntheSink--;
        }
    }
}
