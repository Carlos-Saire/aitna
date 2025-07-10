using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public void Cargar(string name)
    {
        SceneManager.LoadScene(name);
    }
    public void Cerrar()
    {
        Debug.Log("Se cerro el juego");
        Application.Quit();

    }
}
