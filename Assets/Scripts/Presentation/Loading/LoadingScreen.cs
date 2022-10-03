using UnityEngine;

public class LoadingScreen : MonoBehaviour
{
    [SerializeField] private GameObject _goContent;

    private static LoadingScreen _instance;

    private void Start()
    {
        if (CreateSingleton())
        {
            SlicerGame.SceneManager.SceneLoading += OnSceneLoadingStarted;
            SlicerGame.SceneManager.SceneLoaded += OnSceneLoaded;

            if (SlicerGame.SceneManager.IsLoading)
            {
                OnSceneLoadingStarted();
            }
        }
    }

    private bool CreateSingleton()
    {
        var singletonCreated = false;

        if (_instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            singletonCreated = true;
            _instance = this;

            DontDestroyOnLoad(gameObject);
        }

        return singletonCreated;
    }

    private void OnDestroy()
    {
        SlicerGame.SceneManager.SceneLoading -= OnSceneLoadingStarted;
        SlicerGame.SceneManager.SceneLoaded -= OnSceneLoaded;
    }

    private void OnSceneLoadingStarted()
    {
        _goContent.SetActive(true);
    }

    private void OnSceneLoaded(bool success)
    {
        _goContent.SetActive(false);
    }
}
