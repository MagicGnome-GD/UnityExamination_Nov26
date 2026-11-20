using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnButton : MonoBehaviour
{
    public void return_to_menu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
