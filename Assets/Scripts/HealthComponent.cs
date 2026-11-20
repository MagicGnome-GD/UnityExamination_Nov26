using System.Collections;
using TMPro;
using UnityEngine;

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
    }
    
    private IEnumerator Sickness()
    {
        while (true) // Infinite loop
        {
            health -= 1;
            yield return new WaitForSeconds(1f);
        }
    }
}
