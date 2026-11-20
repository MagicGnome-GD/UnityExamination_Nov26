using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenBackstoryScript : MonoBehaviour
{
    public void open_backstory()
    {
        SceneManager.LoadScene("BackstoryScene");
    }
}
