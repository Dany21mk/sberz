using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Master : MonoBehaviour
{
    public Animator panelAnim;
    public Animator infoAnim;
    void Start()
    {
        panelAnim = panelAnim.GetComponent<Animator>();
        infoAnim = infoAnim.GetComponent<Animator>();
        panelAnim.enabled = false;
        infoAnim.enabled = false;
    }

    // Update is called once per frame
    public void SettingsClick()
    {
        panelAnim.enabled = true;
        panelAnim.SetBool("out", false);
    }
    public void SettingsClose()
    {
        panelAnim.SetBool("out", true);
    }
    public void InfoClick()
    {
        infoAnim.enabled = true;
        infoAnim.SetBool("outInfo", false);
    }
    public void InfoClose()
    {
        infoAnim.SetBool("outInfo", true);
    }
    public void StartClick()
    {
        SceneManager.LoadScene(1);
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
