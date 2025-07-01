using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public void Cargar(string name)
    {
        SceneManager.LoadScene(name);
    }

}
