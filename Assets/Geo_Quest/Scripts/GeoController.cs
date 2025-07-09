using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeoController : MonoBehaviour
{
    private int varone = 1;
    private string stone = "How are you";
    int varTwo = 3;
    // Start is called before the first frame update    
    void Start()
    {
        int var2 = 2;
        Debug.Log("Hello World,my name is stone");
        Debug.Log("I think that the class I am learing is intersting");
        string stan = "I'm fine,thank you and you?";
        Debug.Log(stone+"   "+stan);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(varTwo);
        varTwo++;
        varTwo--;
    }
}
