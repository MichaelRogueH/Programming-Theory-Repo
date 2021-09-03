using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animal
{
    //ENCAPSULATION
    [SerializeField]
    private string myName;

    public string Name { get; set; }

    private void Awake()
    {
        Name = myName;
    }

    //INHERITANCE
    //POLYMORPHISM
    // Update is called once per frame
    protected override void Update()
    {
        if (Input.GetKeyDown(KeyCode.K)) // make aninmal speak
        {
            Debug.Log(" Hi, I am the Dog. My Name is " + Name);
        }
        base.Update();
    }
}
