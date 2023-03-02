using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpBar : MonoBehaviour
{
    [SerializeField] GameObject hpBar;

    List<Transform> objectList = new List<Transform>();
    List<GameObject> hpBarList = new List<GameObject>();

    Camera cam;
    void Start()
    {
        cam = Camera.main;

        GameObject[] obj = GameObject.FindGameObjectsWithTag("Enemy");
        for (int i = 0; i < obj.Length; i++)
        {
            objectList.Add(obj[i].transform);
            GameObject _hpBar = Instantiate(hpBar, obj[i].transform.position, Quaternion.identity, transform);
            objectList[i].GetComponent<EnemyHP>().hpSlider = _hpBar.GetComponent<Slider>();
            hpBarList.Add(_hpBar);
        }
    }
    void Update()
    {
        for (int i = 0; i < objectList.Count; i++)
        {
            hpBarList[i].SetActive(IsTargetVisible(cam, objectList[i]));
            hpBarList[i].transform.position = cam.WorldToScreenPoint(objectList[i].position + new Vector3(0, 1.15f, 0));
        }
    }

    public bool IsTargetVisible(Camera _camera, Transform _transform)
    {
        var planes = GeometryUtility.CalculateFrustumPlanes(_camera);
        var point = _transform.position;
        foreach (var plane in planes)
        {
            if (plane.GetDistanceToPoint(point) < 0)
                return false;
        }
        return true;
    }
}