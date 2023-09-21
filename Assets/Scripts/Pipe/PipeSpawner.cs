using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : AbstractMonoBehaviour
{
    [SerializeField] protected List<Transform> prefabs = new();
    [SerializeField] protected float valueY = 0.45f;
    [SerializeField] protected float valueX = 2f;

    protected override void LoadComponent()
    {
        LoadPrefabs();
    }

    private void Start()
    {
        InvokeRepeating(nameof(SetPrefab), 2f, 2f);
    }

    protected virtual void SetPrefab()
    {
        if (GameManager.Instance.IsGameOver) { return; }

        Transform newPrefabs = Spawn(GetRandomPosition(), Quaternion.identity);

        newPrefabs.gameObject.SetActive(true);
        newPrefabs.transform.SetParent(transform);
    }

    protected virtual void LoadPrefabs()
    {
        Transform prefab = transform.Find("Prefabs");
        foreach(Transform child in prefab)
        {
            prefabs.Add(child);
        }
    }

    protected virtual Transform Spawn(Vector3 position, Quaternion rotation)
    {   
        return Instantiate(prefabs[GetRandomPrefab()], position, rotation);
    }

    protected virtual int GetRandomPrefab()
    {
        return Random.Range(0, prefabs.Count);
    }

    protected virtual Vector3 GetRandomPosition()
    {
        Vector3 position = Vector3.zero;
        position.y = Random.Range(-valueY, valueY);
        position.x = valueX;

        return position;
    }
}
