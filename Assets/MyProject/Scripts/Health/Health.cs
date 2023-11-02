using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public abstract class Health : MonoBehaviour
{
    [SerializeField] protected int _health = 15;
    [SerializeField] protected int _maxHealth = 30;

    public UnityEvent Ev_Dead;
    public virtual void AddDamage(int damage)
    {

        Debug.Log("AddDamage [dmg=" + damage + "/cur=" + _health + "/max=" + _maxHealth + "] from " + gameObject.name);
        _health = Mathf.Min(_maxHealth, _health - damage);
        if (_health <= 0)
        {
            Ev_Dead?.Invoke();
            Ev_Dead.RemoveAllListeners();
            //_health = _maxHealth; // - ��������� ��������
        }
    }
}

public interface IHealth
{
    public void AddDamage(int damage);
}

