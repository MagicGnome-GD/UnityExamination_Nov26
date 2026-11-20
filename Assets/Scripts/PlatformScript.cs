using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformScript : MonoBehaviour
{
    // Assign the GameObject you want to toggle in the Inspector
    public GameObject targetObject;

    // Time to wait between toggles
    public float waitTime = 5f;

    private void Start()
    {
        // Validate input
        if (targetObject == null)
        {
            Debug.LogError("Target object is not assigned.");
            return;
        }

        // Start the toggle loop
        StartCoroutine(ToggleLoop());
    }

    private IEnumerator ToggleLoop()
    {
        while (true) // Infinite loop
        {
            // Enable the object
            targetObject.SetActive(true);
            yield return new WaitForSeconds(waitTime);
            
            // Disable the object
            targetObject.SetActive(false);
            yield return new WaitForSeconds(waitTime);
        }
    }
}