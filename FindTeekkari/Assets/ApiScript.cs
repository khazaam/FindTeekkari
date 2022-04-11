using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//This script is for testing the google map api call
public class ApiScript : MonoBehaviour
{

    public RawImage img;

    void Awake()
    {
        img = this.gameObject.GetComponent<RawImage>();
    }

    //Check the api thingie
    IEnumerator Start()
    {
        WWW www = new WWW("");
        yield return www;
        img.texture = www.texture;
        img.SetNativeSize();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
