using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RefHealth : Health
{
    [SerializeField] Health mainHelth;
    public override void AddDamage(int damage)
    {
        //TODO ������ ������� ��� Projectile Attak
        mainHelth.AddDamage(damage);
    }
}
