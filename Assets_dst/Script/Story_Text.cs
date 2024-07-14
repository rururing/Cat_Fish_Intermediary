using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Story_Text : MonoBehaviour
{
    private bool toggle = false;

    public GameObject Script_Screen;
    public void Panel_Set()
    {
        toggle = !toggle;
        Script_Screen.SetActive(toggle);
    }
}
