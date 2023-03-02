using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseScript : MonoBehaviour
{
    [SerializeField] GameObject panel;
    [SerializeField] GameObject player;
    [SerializeField] GameObject gameoverPanel;
    PlayerAttack playerAttack;
    bool isSetActive;
    private void Awake()
    {
        playerAttack = player.GetComponent<PlayerAttack>();
    }
    private void Update()
    {
        if (gameoverPanel.activeSelf == true) return;

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            panel.SetActive(true);
            Time.timeScale = 0;
            Cursor.lockState = CursorLockMode.None;
            playerAttack.isAttackable = false;
        }
    }
    public void ReturnButton()
    {
        panel.SetActive(false);
        OffPanel();
    }

    public void ReplayButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        OffPanel();
    }

    public void LobbyButton()
    {
        SceneManager.LoadScene("Lobby");
        Time.timeScale = 1;
        playerAttack.isAttackable = true;
    }

    void OffPanel()
    {
        Time.timeScale = 1;
        Cursor.lockState = CursorLockMode.Locked;
        playerAttack.isAttackable = true;
    }
}
