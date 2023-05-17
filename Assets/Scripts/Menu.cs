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

    bool isStop = true;//��־λ�����ж���Ϸ�Ƿ���Ҫ����ͣ
    public GameObject option;//�����ҵ�����UI����
    // Update is called once per frame
    void Update()
    {
        //��Ϸ��Ҫ����ͣ������ESC����Ϸ��ͣ����ʾ�ҵ�����UI���棬Ȼ�󽫱�־λ���ó�false���ȴ��´ε��ESC������Ϸ
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
        //��Ϸ����Ҫ����ͣ������ESC����Ϸ�����������ҵ�����UI���棬Ȼ�󽫱�־λ���ó�true���ȴ��´ε��ESC��ͣ��Ϸ
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
