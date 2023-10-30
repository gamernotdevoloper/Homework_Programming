using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject preFab;
    public Transform bulletTrash;
    public Transform bulletSpawn;

    private const float Timer = 0.5f;
    private float _currentTime = 0.5f;
    private bool _canShoot = true;

    void Update()
    {
        BulletSpawnTimer();
        SpawnBullet();
    }
    private void BulletSpawnTimer()
    {
        if (_canShoot) return;
        _currentTime -= Time.deltaTime;
        if (!(_currentTime <= 0)) return;
        _currentTime = Timer;
        _canShoot = true;
    }
    private void SpawnBullet()
    {
        if (!Input.GetKey(KeyCode.Mouse0) || !_canShoot) return;
        var bullet = Instantiate(preFab, bulletSpawn.position, Quaternion.identity);
        bullet.transform.SetParent(bulletTrash);
        _canShoot = false;
    }
}
