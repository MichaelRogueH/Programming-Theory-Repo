using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class UIMenu : MonoBehaviour
{
    //find your dropdown object
    public TMP_Dropdown dropdownMenu;

    //get the selected index
    

    //get all options available within this dropdown menu
    //List<Dropdown.OptionData> menuOptions = dropdownMenu.GetComponent<Dropdown>().options;

    //get the string value of the selected index
    //string value = menuOptions[menuIndex].text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartNew()
    {
        Debug.Log(dropdownMenu.value);
        GameManager.Instance.animalSelection = dropdownMenu.value;
        Debug.Log("UIMenu: Animal number :" + GameManager.Instance.animalSelection);
        SceneManager.LoadScene(1);
    }
}
