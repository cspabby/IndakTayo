using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class GotoJotabal : MonoBehaviour
{
    public string stageName;
    public string music;
    public GameObject loadingScreen;
    public Slider loadingSlider;
    public TextMeshProUGUI progressText;
    public Slider ScreenloadingSlider;
    public TextMeshProUGUI ScreenprogressText;
    public GameObject ScreenLoadingDisplay;

    public void MoveToJotabal_Dance()
    {
        PlayerPrefs.SetString("stage", stageName);
        PlayerPrefs.Save();
        PlayerPrefs.SetString("music", music);
        PlayerPrefs.Save();
        StartCoroutine(LoadScene("Jotabal_Dance"));
    }

    IEnumerator LoadScene(string sceneName)
    {
         loadingScreen.SetActive(true);
       ScreenLoadingDisplay.SetActive(true);
      //  ScreenDisplay.SetActive(false);


        float progress = 0f;

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(sceneName);

        asyncLoad.allowSceneActivation = false; // scene will not load while this value is false

        while (progress < 1f)
        {
            progress += 0.01f;

           
            progress = Mathf.Clamp01(progress);

            loadingSlider.value = progress;

            // Update the progress text
            progressText.text = "Loading: " + (progress * 100f).ToString("F0") + "%";

            ScreenloadingSlider.value = progress;

            // Update the progress text
            ScreenprogressText.text = "Loading: " + (progress * 100f).ToString("F0") + "%";

            yield return new WaitForSeconds(0.01f);
        }

        // Allow the scene to be activated
        asyncLoad.allowSceneActivation = true;

        // Wait for the scene to finish loading
        while (!asyncLoad.isDone)
        {
            yield return null;
        }

        // Deactivate the loading screen after the scene is loaded
        loadingScreen.SetActive(false);
    }
}
