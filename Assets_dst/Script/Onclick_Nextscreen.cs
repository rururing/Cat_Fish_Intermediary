using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Onclick_Nextscreen : MonoBehaviour
{  
    public GameObject nextscreen;
    public void Next_Scene(string a)
    {
        StartCoroutine(start_effect(a));
    }

    IEnumerator start_effect(string a)
    {
        nextscreen.SetActive(true);
        float alpha = 0.0f;
        while (alpha < 1)
        {
            alpha += 0.02f;
            nextscreen.GetComponent<Image>().color = new Color(1, 1, 1, alpha);
            yield return new WaitForSeconds(0.01f);

        }
        SceneManager.LoadScene(a);
    }
}


