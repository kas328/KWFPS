using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunReload : MonoBehaviour
{
    PlayerAttack playerAttack;

    private void Awake()
    {
        playerAttack = GetComponent<PlayerAttack>();
    }
    // Update is called once per frame
    void Update()
    {
        if(playerAttack.bulletCount <= 0)
        {

        }
    }
    void Reload()
    {

    }
}
// 총알 장전
// 1. 총알이 6발 주어져야 한다.
// 2. 총알을 다 사용하면 재장전을 한다.
// 3. R키를 누르면 재장전을 한다.
