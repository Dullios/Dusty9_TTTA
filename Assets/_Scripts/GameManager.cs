using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject boardPrefab;
    private GameObject[,] boards;
    [SerializeField] private float horizontalBoardSpacing;
    [SerializeField] private float verticalBoardSpacing;

    // Start is called before the first frame update
    void Start()
    {
        boards = new GameObject[3, 3];

        GenerateBoards();
    }

    public void GenerateBoards()
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                GameObject temp = Instantiate(boardPrefab, new Vector3(transform.position.x + (horizontalBoardSpacing * j), transform.position.y + (verticalBoardSpacing * i), transform.position.z),
                    Quaternion.identity, gameObject.transform);

                boards[j, i] = temp;

                temp.GetComponent<BoardGenerator>().GenerateCells();
            }
        }
    }
}
