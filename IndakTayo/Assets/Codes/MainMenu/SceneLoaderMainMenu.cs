using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;


public class SceneLoaderMainMenu : MonoBehaviour
{
    public GameObject loadingScreen;
    public Slider loadingSlider;
    public TextMeshProUGUI progressText;
    public Slider ScreenloadingSlider;
   public TextMeshProUGUI ScreenprogressText;
   public GameObject ScreenLoadingDisplay;
  //  public GameObject ScreenDisplay;
  //  public CanvasToggleX deactivate;

    // This method is called when the button is clicked
    public void MoveToJotabal_Dance()
    {
  
            StartCoroutine(LoadScene("Jotabal_Dance"));
 
 

    }

    public void MoveToPolkabal_Dance()
    {
  
            StartCoroutine(LoadScene("Polkabal_Dance"));
   
    }


    public void MoveToMain_Menu()
    {
        StartCoroutine(LoadScene("MainMenu"));
    }

    public void MoveToHow_to_Play()
    {
        StartCoroutine(LoadScene("How_to_Play"));
    }

    public void MoveToAbout()
    {
        StartCoroutine(LoadScene("About"));
    }


    public void QuitGame()
    {
        Application.Quit();
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(LoadScene("How_to_Play"));
        }
    }


    IEnumerator LoadScene(string sceneName)
    {
        // Activate the loading screen
     //   deactivate.DeactivateScript();
        loadingScreen.SetActive(true);
       ScreenLoadingDisplay.SetActive(true);
      //  ScreenDisplay.SetActive(false);


        float progress = 0f;

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(sceneName);

        asyncLoad.allowSceneActivation = false; //scene will not load while this value is false

        while (progress < 1f)
        {
            progress += 0.01f;

            // Ensure progress stays within the range [0, 1]
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
