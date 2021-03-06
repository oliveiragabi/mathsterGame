using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Carreganivel : MonoBehaviour {

    public void carregaNivel(int level)
    {
        SceneManager.LoadScene(level);
    }
	
	// Update is called once per frame
	public void Sair () 
    {

        Application.Quit();
	}
}
