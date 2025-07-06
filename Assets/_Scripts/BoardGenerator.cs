using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardGenerator : MonoBehaviour
{
    [SerializeField] private GameObject cellPrefab;
    [SerializeField] private float horizontalCellSpacing;
    [SerializeField] private float verticalCellSpacing;

    private GameObject[,] cells;

    private void Awake()
    {
        cells = new GameObject[3,3];
    }

    //private void Start()
    //{
    //    GenerateCells();
    //}

    public void GenerateCells()
    {
        for(int i = 0; i < 3; i++)
        {
            for(int j = 0; j < 3; j++)
            {
                GameObject temp = Instantiate(cellPrefab, new Vector3(transform.position.x + (horizontalCellSpacing * j), transform.position.y + (verticalCellSpacing * i), transform.position.z),
                    Quaternion.identity, gameObject.transform);
                temp.GetComponent<CellBehaviour>().x = j;
                temp.GetComponent<CellBehaviour>().y = i;

                cells[j, i] = temp;
            }
        }
    }
}
