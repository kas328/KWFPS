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
// �Ѿ� ����
// 1. �Ѿ��� 6�� �־����� �Ѵ�.
// 2. �Ѿ��� �� ����ϸ� �������� �Ѵ�.
// 3. RŰ�� ������ �������� �Ѵ�.
