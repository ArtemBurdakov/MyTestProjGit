using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ItemInPool : MonoBehaviour,IItemInPool
{

    public UnityEvent Ev_EntryToPool;
    public void InstantinatePoolObj()
    {
        //��� ������ ���������� ����
        gameObject.transform.position = Vector3.zero;
        gameObject.SetActive(false);

    }
    public void InstantinatePoolObj(string addName)
    {
        gameObject.name += addName;
        InstantinatePoolObj();
    }

    public void EntryToPool()
    {
        //����������� � ���
        gameObject.transform.position = Vector3.zero;
        gameObject.SetActive(false);
        Ev_EntryToPool?.Invoke();
        Ev_EntryToPool.RemoveAllListeners();
    }


    public void ExitFromPool()
    {
        //������ ������ �������
        gameObject.SetActive(true);
    }
    public void ExitFromPool(Vector3 coordSpawn)
    {
        gameObject.transform.position = coordSpawn;
        ExitFromPool();
    }

    public GameObject GetGameObject()
    {
        return gameObject;
    }
}

public interface IItemInPool
{
    public GameObject GetGameObject();

    /// <summary>
    /// ��� ��������� ����
    /// � ��� ���������� �����(���� ������������ ����� ���������)
    /// </summary>
    public void InstantinatePoolObj();

    /// <summary>
    /// ����������� � ���
    /// ������ Destroy
    /// </summary>
    public void EntryToPool();


    /// <summary>
    /// ������ �� ����
    /// ������ Instantinate �������
    /// </summary>
    public void ExitFromPool();
}
