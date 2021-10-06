using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    private static SceneController _instance;
    public static SceneController Instance
    {
        get
        {
            if(_instance == null)
            {
                _instance = FindObjectOfType<SceneController>();
            }
            return _instance;
        }
    }

    private GameController _gameController;
    public List<string> nextSceneList;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(Instance);
        SetGameController();
    }

    void SetGameController()
    {
        _gameController = FindObjectOfType<GameController>();
        _gameController.OnGameEnded += ChangeNextScene;
    }

    void ChangeNextScene()
    {
        Debug.Log("Changing Scene");
        if (_gameController != null)
        {
            _gameController.OnGameEnded -= ChangeNextScene;
        }

        SceneManager.LoadScene(nextSceneList[0]);
        nextSceneList.RemoveAt(0);

        SetGameController();
    }
}
