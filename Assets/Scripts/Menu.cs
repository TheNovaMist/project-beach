using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    bool isStop = true;//标志位，来判断游戏是否需要被暂停
    public GameObject option;//这是我的设置UI界面
    // Update is called once per frame
    void Update()
    {
        //游戏需要被暂停，按下ESC，游戏暂停，显示我的设置UI界面，然后将标志位设置成false，等待下次点击ESC启动游戏
        if (isStop == true)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                Time.timeScale = 0;
                isStop = false;
                option.SetActive(true);
                Cursor.lockState = CursorLockMode.None;
            }
        }
        //游戏不需要被暂停，按下ESC，游戏启动，隐藏我的设置UI界面，然后将标志位设置成true，等待下次点击ESC暂停游戏
        else
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                Time.timeScale = 1;
                isStop = true;
                option.SetActive(false);
            }
        }
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("Main");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void BackToMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Menu");
    }
    public void BackCancel()
    {
        Time.timeScale = 1;
        isStop = true;
        option.SetActive(false);
    }

}
