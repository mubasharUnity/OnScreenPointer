using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransitionManager : MonoBehaviour
{
    private int currentLevelIndex = 0;

    private void Start()
    {
        LoadLevelWithIndex(1);
    }

    public void LoadLevelWithIndex(int index)
    {
        UnLoadExistingLevel();
        currentLevelIndex = index;
        SceneManager.LoadScene(index, LoadSceneMode.Additive);
    }

    private void Update()
    {
    }

    private void UnLoadExistingLevel()
    {
        if (currentLevelIndex != 0)
        {
            _ = SceneManager.UnloadSceneAsync(currentLevelIndex);
        }
    }
}
