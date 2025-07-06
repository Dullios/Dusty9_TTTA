using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CellBehaviour : MonoBehaviour
{
    public enum CellStates {Blank, X, O};

    public CellStates cellState = CellStates.Blank;

    public int x, y;
}
