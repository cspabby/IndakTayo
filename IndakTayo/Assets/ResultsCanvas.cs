using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResultsCanvas : MonoBehaviour
{
    public AttemptsValue attempts;         // Reference to manage attempts
    public SelectDifficulty difficulty;   // Reference to SelectDifficulty instance
    private string difficultyValue;       // Store the current difficulty value

    void Start()
    {
        // Initialize difficulty value to avoid relying on Update
        if (difficulty != null)
        {
            difficultyValue = SelectDifficulty.GetDifficulty();
        }
        else
        {
            Debug.LogWarning("SelectDifficulty is not assigned in the inspector.");
        }
    }

    void Update()
    {
        // Continuously update difficultyValue only if necessary
        if (difficulty != null)
        {
            difficultyValue = SelectDifficulty.GetDifficulty();
            Debug.Log("Diff: " + difficultyValue);
        }
    }

    public void TryAgain()
    {
        // Reload the current scene for retrying
        StartCoroutine(LoadScene("Jotabal_Dance"));
    }

    public void Next()
    {
        // Adjust difficulty settings based on the current difficulty value
        if (!string.IsNullOrEmpty(difficultyValue))
        {
            if (difficultyValue == "Easy")
            {
                PlayerPrefs.SetInt("isAverage", 1); // Unlock Average difficulty
                PlayerPrefs.SetInt("attempts", 0);
            }
            else if (difficultyValue == "Average")
            {
                PlayerPrefs.SetInt("isHard", 1);   // Unlock Hard difficulty
                PlayerPrefs.SetInt("attempts", 0);
            }
            PlayerPrefs.Save();
        }
        else
        {
            Debug.LogError("Difficulty value is null or empty. Cannot proceed to the next level.");
        }

        // Reset attempts and load the scene
        attempts.ResetAttempts();
        StartCoroutine(LoadScene("Jotabal_Dance"));
    }


    public void MoveToMain_Menu()
    {
        // Reset attempts and navigate to the main menu
        attempts.ResetAttempts();
        StartCoroutine(LoadScene("MainMenu"));
    }

    private IEnumerator LoadScene(string sceneName)
    {
        // Asynchronously load the specified scene
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(sceneName);

        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }
}
