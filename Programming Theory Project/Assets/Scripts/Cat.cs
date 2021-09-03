using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : Animal
{
    // Update is called once per frame
    protected override void Update()
    {
        if (Input.GetKeyDown(KeyCode.K)) // make aninmal speak
        {
            Debug.Log(" Hi, I am the Cat");
        }
        base.Update();
    }
}
