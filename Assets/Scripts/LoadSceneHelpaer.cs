using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneHelpaer : MonoBehaviour
{
    public void Load(int i)
    {
        SceneManager.LoadScene(i);
    }
    public void Load(string s)
    {
        SceneManager.LoadScene(s);
    }
}
