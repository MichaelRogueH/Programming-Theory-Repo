using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainManager : MonoBehaviour
{
    // Reference to the Prefab. Drag a Prefab into this field in the Inspector.
    public GameObject myPrefabCat;
    public GameObject myPrefabDog;
    public GameObject myPrefabChicken;
    private GameObject myPrefab;

    public GameObject animalScript;
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Animal number :" + GameManager.Instance.animalSelection);
        switch (GameManager.Instance.animalSelection)
        {
            case  1:
                myPrefab = myPrefabDog;
                break;

            case 2:
                myPrefab = myPrefabCat;
                break;

            default:
                myPrefab = myPrefabChicken;
                break;
        }

      
        Instantiate(myPrefab, new Vector3(0, 0, 0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown (KeyCode.K)) // make aninmal speak
        {
           animalScript.GetComponent<Animal>().AnimalSpeak("Hi");
        }
    }
}
