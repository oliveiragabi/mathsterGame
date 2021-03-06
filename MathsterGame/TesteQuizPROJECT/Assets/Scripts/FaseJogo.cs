using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class FaseJogo : MonoBehaviour {
	public Button botaoplay;
	public Text   txtNomeFase;
	public GameObject InfoFase;

	public string[]  nomeFase;
	public int numeroQuestoes;
	private int       idFase;

	void Start () {
		idFase = 0;
		txtNomeFase.text = nomeFase [idFase];
		InfoFase.SetActive (false);


	}

    public void selecioneFase(int i)
    {
        idFase = i;
        txtNomeFase.text = nomeFase[i];
		int notaFinal=0;
		int acertos=0; 
		InfoFase.SetActive(true);
        

    }
	public void jogar()
	{
		SceneManager.LoadScene ("F" + idFase.ToString ());	
	}



    public void Sair()
	{
		Application.Quit ();
	}



	}