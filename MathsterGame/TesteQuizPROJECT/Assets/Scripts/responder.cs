using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class responder : MonoBehaviour {
    public Contador contador;

	private int idFase;
    public Text pontuacao;
	public Text pergunta;
	public Text respostaA;
	public Text respostaB;

	public string[] perguntas;       //armazena todas as perguntas
	public string[] alternativaA;    //armazena todas as alternativas A 
	public string[] alternativaB;    //armazena as alternativas B
	public string[] alternativasCorretas; //armazena as alternativas corretas

	private int idPergunta;
    private int seguidas = 0;

	private float acertos;
	private int notaFinal;
	private float questoes;
	private float media;

	// Use this for initialization
	void Start () 

	{
		idFase = PlayerPrefs.GetInt ("idFase");
		idPergunta=0;
		questoes = perguntas.Length;

		pergunta.text = perguntas[idPergunta];
		respostaA.text = alternativaA[idPergunta];
		respostaB.text = alternativaB[idPergunta];	

	}
	public void resposta(string alternativa)
	{
		if (alternativa == "A")
		{
            if (alternativaA[idPergunta] == alternativasCorretas[idPergunta])
            {
                acertos += 100;
                seguidas++;
                if (seguidas == 5)
                {
                    contador.cronometro += 10;
                    seguidas = 0;
                }
            }
            else
            {
                seguidas = 0;
                contador.cronometro -= 3;
            }
			proximaPergunta();
		}

		else if (alternativa == "B")
		{
			if (alternativaB[idPergunta] == alternativasCorretas[idPergunta])
			{
				acertos += 100;
                seguidas++;
                if (seguidas == 5)
                {
                    contador.cronometro += 10;
                    seguidas = 0;
                }
            }
            else
            {
                seguidas = 0;
                contador.cronometro -= 3;
            }
			proximaPergunta();
		}

	}
	public void proximaPergunta ()
	{
		idPergunta += 1;

		if (idPergunta <= (questoes - 1)) {
            pontuacao.text = acertos.ToString();
			pergunta.text = perguntas [idPergunta];
			respostaA.text = alternativaA [idPergunta];
			respostaB.text = alternativaB [idPergunta];
		} else {

			media = 10 * (acertos / questoes);
			notaFinal = Mathf.RoundToInt (media);

			if (notaFinal > PlayerPrefs.GetInt ("notaFinal" + idFase.ToString ())) {
				PlayerPrefs.SetInt ("notaFinal" + idFase.ToString (), notaFinal);
				PlayerPrefs.SetInt ("acertos" + idFase.ToString (), (int)acertos);

				Application.LoadLevel ("notaFinal");
			}
	
		
		}

	}
}