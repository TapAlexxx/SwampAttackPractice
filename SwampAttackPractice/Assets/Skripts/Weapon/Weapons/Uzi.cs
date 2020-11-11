using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Uzi : Weapon
{
    [SerializeField] private float _shootPointSpread;

    public override void Shoot(Transform shootPoint)
    {
        float spread = Random.Range(-_shootPointSpread, _shootPointSpread);
        Bullet bullet = Instantiate(Bullet, new Vector3(shootPoint.position.x, shootPoint.position.y + spread, 0), Quaternion.identity);
        Destroy(bullet.gameObject, 0.2f); 
    }
}
