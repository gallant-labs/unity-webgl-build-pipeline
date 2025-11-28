using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    private int score;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI appVersion;

    public static GameManager Instance; // allow only singleton GameManager object



    // Make sure gameManager is retained between scenes
    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject); // Destroy duplicate instances
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // Preserve the GameObject
        }

    }

    // Start is called before the first frame update
    void Start()
    {
        score = 0;

        if (scoreText != null)
        {
            scoreText.text = "Score: " + score;
        }
        else
        {
            Debug.Log("scoreText is not assigned!");
        }

        if (appVersion != null)
        {
            appVersion.text = "Version " + Application.version;
        }
        else
        {
            Debug.Log("appVersion is not assigned!");
        }
        Debug.Log("appVersion.text = " + Application.version);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnEnable()
    {
        Debug.Log("OnEnable called");
        SceneManager.sceneLoaded += OnSceneLoaded;

    }

    private void OnDisable()
    {
        Debug.Log("OnDisable called");
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        Debug.Log("Scene Loaded: " + scene.name);

        // Reassign UI elements for each scene dynamically
        if (scene.name == "MazeLevel1")
        {
            scoreText = GameObject.Find("ScoreText")?.GetComponent<TextMeshProUGUI>();
            appVersion = GameObject.Find("AppVersion")?.GetComponent<TextMeshProUGUI>();

            // Locate and assign the QuitButton for the "MazeLevel1" scene
            GameObject quitButtonObj = GameObject.Find("QuitButton");

            if (quitButtonObj != null)
            {
                Button quitButton = quitButtonObj.GetComponent<Button>();

                if (quitButton != null)
                {
                    quitButton.onClick.RemoveAllListeners();
                    quitButton.onClick.AddListener(QuitGame); // Add our QuitGame method as the listener
                }
            }
        }

        if (scene.name == "StartMenu")
        {
            // Locate and assign button listeners in StartMenu
            GameObject startButtonObj = GameObject.Find("StartButton");

            if (startButtonObj != null)
            {
                Button startButton = startButtonObj.GetComponent<Button>();
                if (startButton != null)
                {
                    startButton.onClick.RemoveAllListeners(); // Clear any previous listeners to avoid duplication
                    startButton.onClick.AddListener(StartGame); // Add our StartGame method as the listener
                }

            }


        }
    }

    public void StartGame()
   {
        Debug.Log("Welcome to my game!");
        SceneManager.LoadScene("MazeLevel1");

        // Reset score to zero
        score = 0;

        if (scoreText != null)
        {
            scoreText.text = "Score: " + score;
        }
    }

    // Update score by amount passed in 
    public void UpdateScore(int amount)
    {
        score += amount;
        scoreText.text = "Score is: " + score;
    }

    public void QuitGame()
    {
        // Return to menu screen
        Debug.Log("Sorry to see you go!");
        SceneManager.LoadScene("StartMenu");


        // do I need to reset things?
    }
}
