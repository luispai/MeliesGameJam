﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    public AudioSource Botao;
    public GameObject imagemabregame;

    public void Play()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); // 1 cutscene
    }

    public void Menuzin()
    {
        SceneManager.LoadScene("Menu");
    }
    public void Quit()
    {
        Application.Quit();
    }
   

    public void Final()
    {
        SceneManager.LoadScene("FINAL");
    }

    public void Level()
    {
        SceneManager.LoadScene("Level");
    }

   public void TocaBotao()
    {
        Botao.Play();
    }

    public void DesativaTelao()
    {
        imagemabregame.SetActive(false);
    }
}
