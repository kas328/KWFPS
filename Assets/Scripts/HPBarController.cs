using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPBarController : MonoBehaviour
{
    Transform container;
    [SerializeField] GameObject hpBar;

    GameObject _hpBar;

    Camera cam;
    void Start()
    {
        cam = Camera.main;
        container = GameObject.Find("Canvas").transform;
        _hpBar = Instantiate(hpBar);
        _hpBar.transform.SetParent(container);
        GetComponent<EnemyHP>().hpSlider = _hpBar.GetComponent<Slider>();
    }
    void Update()
    {
        Debug.Log(0);
        bool value = IsTargetVisible(cam, transform);
        Debug.Log($"5 : {_hpBar}");

        _hpBar.SetActive(value);
        Debug.Log(6);

        _hpBar.transform.position = cam.WorldToScreenPoint(transform.position + new Vector3(0, 1.15f, 0));
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
