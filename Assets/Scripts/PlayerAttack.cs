using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField] Camera cam;
    [SerializeField] GameObject bulletEffect;
    Vector3 screenCenter;
    public bool isAttackable = true;
    public int bulletCount;

    private void Start()
    {
        screenCenter = new Vector3(cam.pixelWidth / 2, cam.pixelHeight / 2);
    }
    void LateUpdate()
    {
        if (!isAttackable) return;
        Debug.DrawRay(cam.ScreenToWorldPoint(screenCenter), cam.transform.forward * 30, Color.green);
        if (Input.GetButtonDown("Fire1"))
        {
            bulletCount--;
            RaycastHit hit;
            if (Physics.Raycast(cam.ScreenToWorldPoint(screenCenter), cam.transform.forward, out hit, Mathf.Infinity))
            {
                GameObject effect = Instantiate(bulletEffect);
                effect.transform.position = hit.point;
                EnemyHP enemyHP = hit.transform.GetComponent<EnemyHP>();
                if(enemyHP) enemyHP.CurrentHP--;
            }
        }
    }
}
