using System.Collections;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthComponent : MonoBehaviour
{
    public int health = 20;
    public GameObject healthText;
    private TMP_Text textComponent;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        textComponent = healthText.GetComponent<TMP_Text>();
        StartCoroutine(Sickness());
    }

    // Update is called once per frame
    void Update()
    {
        textComponent.text = "Health: " + health.ToString();
        if (health <= 0)
        {
            SceneManager.LoadScene("MainMenu");
            Debug.Log("You died!");
        }
    }
    
    private IEnumerator Sickness()
    {
        while (true) // Infinite loop
        {
            health -= 1;
            yield return new WaitForSeconds(1f);
        }
    }

    void OnTriggerEnter(Collider2D other)
    {
        if (other.gameObject.CompareTag("Spikes"))
        {
            health = 0;
        }
    }
}
