using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RefHealth : Health
{
    //������� ���������������� ���� � (gameobject"EnemyAgent" + RefHealth) �� (gameobject"Capsule" + mainHelth)
    [SerializeField] Health mainHelth;
    public override void AddDamage(int damage)
    {
        //TODO ������ ������� ��� Projectile Attak
        mainHelth.AddDamage(damage);
    }
}
