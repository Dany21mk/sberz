using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public Animator gameOverAnim;
    public AudioClip overAudio;
    AudioSource audioS;

    // Update is called once per frame
    void Start()
    {
        gameOverAnim = gameOverAnim.GetComponent<Animator>();
        gameOverAnim.enabled = false;
        audioS = GetComponent<AudioSource>();
    }
    public void GameOverFun()
    {
        audioS.clip = overAudio;
        if (!audioS.isPlaying)
        {
            audioS.Play();
        }
        audioS.volume = 1;
        gameOverAnim.enabled = true;
        gameOverAnim.SetBool("gameOver", false);
    }
    public void beginClick()
    {
        SceneManager.LoadScene(1);
    }
    public void GoToMenu()
    {
        SceneManager.LoadScene(0);
    }
}
