using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animal
{
    [SerializeField]
    private string myName;

   
    // Update is called once per frame
    protected override void Update()
    {
        if (Input.GetKeyDown(KeyCode.K)) // make aninmal speak
        {
            Debug.Log(" Hi, I am the Dog. My Name is " + myName);
        }
        base.Update();
    }
}
