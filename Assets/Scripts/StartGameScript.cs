using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGameScript: MonoBehaviour
{
    public void start_game()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
