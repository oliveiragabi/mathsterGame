using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Contador : MonoBehaviour {
	public Text txtcronometro;
	public float cronometro;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (cronometro > 0.0f) 
		{
			cronometro -= Time.deltaTime;
			txtcronometro.text = cronometro.ToString ("F1");
		} 
		else
		{
			txtcronometro.text = "O JOGO ACABOU";
			SceneManager.LoadScene ("Gameover");
		}
		 

	}
}
