using JHS;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHP : HPFrame
{
    public Slider hpSlider;
    [SerializeField] GameObject gameoverPanel;
    [SerializeField] GameObject player;
    PlayerAttack playerAttack;

    private void Awake()
    {
        playerAttack = player.GetComponent<PlayerAttack>();
    }
    protected override void RefreshUIElement()
    {
        hpSlider.value = CurrentHP / MaxHP;
    }

    protected override void OnDeath()
    {
        gameoverPanel.SetActive(true);
        Time.timeScale = 0;
        Cursor.lockState = CursorLockMode.None;
        playerAttack.isAttackable = false;
    }
}
