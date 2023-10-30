using UnityEngine;

public class ShipRotation : MonoBehaviour
{
    private Camera _camera;
    private Vector3 _mousePos;

    public void Start()
    {
        _camera = GameObject.Find("Game_Camera").GetComponent<Camera>();
    }

    void Update()
    {
        _mousePos = _camera.ScreenToWorldPoint(Input.mousePosition);
        var pos = _mousePos - transform.position;
        var rotZ = Mathf.Atan2(pos.y, pos.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, rotZ - 90); 
    }
}
