using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenePause : MonoBehaviour
{
    public GameObject PausePanel;
    public void PauseButtonPressed()
    {
        PausePanel.SetActive(true); //включает игровой обект на сцене
        Time.timeScale = 0f; // втора€ позвол€ет управл€ть временем (если на 1, то врем€ длитс€ как обычно)
    }
    public void ContinueButtonPressed()
    {
        PausePanel.SetActive(false); //отключаем панель паузы
        Time.timeScale = 1f; //
    }
    public void RestartButtonPressed()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); //позвол€ет загрузить сцену (в скобках функцы€ возвращает текущую сцену)
        Time.timeScale = 1f; // и возвращаем врем€
    }
    public void ChangeScene(int scene)
    {
        SceneManager.LoadScene(scene); //
        Time.timeScale = 1f;
    }
}
