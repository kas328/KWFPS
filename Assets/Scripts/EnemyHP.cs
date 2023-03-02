using JHS;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHP : HPFrame
{
    public Slider hpSlider;
    Animator anim;
    bool isDie;
    public bool IsDie => isDie;
    
    private void Awake()
    {
        anim = GetComponentInChildren<Animator>();
    }
    protected override void RefreshUIElement()
    {
        hpSlider.value = CurrentHP / MaxHP;
    }

    protected override void OnDeath()
    {
        anim.SetTrigger("DIE");
        Destroy(hpSlider.gameObject);
        Destroy(GetComponent<HPBarController>());
        GetComponent<Collider>().enabled = false;
        isDie = true;
        Destroy(gameObject, 5f);
    }
}