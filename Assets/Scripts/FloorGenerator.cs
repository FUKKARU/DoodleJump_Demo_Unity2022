using UnityEngine;

public class FloorGenerator : MonoBehaviour
{
    [SerializeField] private GameObject[] floorPrefabs;
    [SerializeField] private float heightGeneratePercentage;
    [SerializeField] private Transform floorParent;

    private void Start()
    {
        GenerateFloor();
    }

    private void GenerateFloor()
    {
        // y座標-1から1000まで、0.5刻みに、その高度に生成するかランダムに決定する。
        // 生成する場合、x座標は-7から7の間のランダムな値にする。
        // 生成するものは、候補のプレハブの中からランダムに決定する。

        for (float y = -1; y < 1000; y += 0.5f)
        {
            if (Random.value < heightGeneratePercentage)
            {
                GameObject prefab = floorPrefabs[Random.Range(0, floorPrefabs.Length)];
                float x = Random.Range(-7f, 7f);
                Instantiate(prefab, new Vector2(x, y), Quaternion.identity, floorParent);
            }
        }
    }
}
