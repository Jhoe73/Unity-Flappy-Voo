using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class Pontuacao : MonoBehaviour
{
    [SerializeField]
    private Text textoPontuacao;
    public int Pontos {get; private set;}
    private AudioSource audioPontuacao;

    private void Awake()
    {
        this.audioPontuacao = this.GetComponent<AudioSource>();
    }

    public void AdicionarPontos()
    {
        this.Pontos++;
        this.textoPontuacao.text = this.Pontos.ToString();
        this.audioPontuacao.Play();
    }

    public void Reiniciar()
    {
        this.Pontos = 0;
        this.textoPontuacao.text = this.Pontos.ToString();
    }

    public void Esconder()
    {
        this.textoPontuacao.enabled = false; 
    }

    public void Mostrar()
    {
        this.textoPontuacao.enabled = true;
    }

    public int GetPontos()
    {
        return this.Pontos;
    }

    public void SalvarRecorde()
    {
        int recordeAtual = PlayerPrefs.GetInt("recorde");
        if (this.Pontos > recordeAtual)
        {
            PlayerPrefs.SetInt("recorde", this.Pontos);
        }
        
    }
}
