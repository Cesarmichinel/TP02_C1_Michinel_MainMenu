using UnityEngine;
using UnityEngine.UI;

public class UiManager : MonoBehaviour
{
    //[SerializeField] private TMP_Text profileName;   

    [SerializeField] private GameObject mainMenuCanvas;
    [SerializeField] private GameObject mainMenu;
    [SerializeField] private Button btnPlay;
    [SerializeField] private GameObject gameContainer;

    [SerializeField] private GameObject panelSettings;
    [SerializeField] private Button btnSettingsPanel;
    [SerializeField] private Button btnback;

    [SerializeField] private GameObject panelCredits;
    [SerializeField] private Button btnCreditsPanel;
    [SerializeField] private Button btnBackCredits;

    [SerializeField] private Button btnExit;

    [SerializeField] private GameObject panelPause;
    [SerializeField] private Button btnContinue;
    [SerializeField] private Button btnSettingsFromPause;
    [SerializeField] private Button btnCreditsFromPause;
    [SerializeField] private Button btnExitFromPause;

    private GameObject previousPanel;
    private bool isPaused = false;


    private void Start()
    {

        gameContainer.SetActive(false);
        panelSettings.SetActive(false);
        panelCredits.SetActive(false);
        panelPause.SetActive(false);


        btnPlay.onClick.AddListener(PlayGame);

        btnSettingsPanel.onClick.AddListener(() => OpenSettings(mainMenu));
        btnback.onClick.AddListener(CloseSettings);

        btnCreditsPanel.onClick.AddListener(() => OpenCredits(mainMenu));
        btnBackCredits.onClick.AddListener(CloseCredits);

        btnExit.onClick.AddListener(ExitGame);

        btnContinue.onClick.AddListener(TogglePause);
        btnSettingsFromPause.onClick.AddListener(() => OpenSettings(panelPause));
        btnCreditsFromPause.onClick.AddListener(() => OpenCredits(panelPause));
        btnExitFromPause.onClick.AddListener(ExitGame);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            TogglePause();
        }
    }

    private void PlayGame()
    {
        mainMenuCanvas.SetActive(false);
        gameContainer.SetActive(true);
    }

    private void TogglePause()
    {
        isPaused = !isPaused;
        panelPause.SetActive(isPaused);
        Time.timeScale = isPaused ? 0f : 1f;
    }
    private void OpenSettings(GameObject caller)
    {
        previousPanel = caller;
        caller.SetActive(false);
        panelSettings.SetActive(true);
    }
    private void CloseSettings()
    {
        panelSettings.SetActive(false);
        previousPanel.SetActive(true);
    }

    private void OpenCredits(GameObject caller)
    {
        previousPanel = caller;
        caller.SetActive(false);
        panelCredits.SetActive(true);
    }

    private void CloseCredits()
    {
        panelCredits.SetActive(false);
        previousPanel.SetActive(true);
    }

    private void ExitGame()
    {
        Application.Quit();
    }

}


