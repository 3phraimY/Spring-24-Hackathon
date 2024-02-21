using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Singleton : MonoBehaviour
{
    public static Singleton singleton;
    public static int Score;
    // Start is called before the first frame update
    void Start()
    {
        if (singleton == null)
            singleton = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
