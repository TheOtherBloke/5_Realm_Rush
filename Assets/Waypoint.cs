using UnityEngine;

public class Waypoint : MonoBehaviour
{
    // [SerializeField] Color exploredColor;

    // public ok here as is a data class
    public bool isExplored = false;
    public Waypoint exploredFrom;

    Vector2Int gridPos;

    const int gridSize = 10;

    public int GetGridSize()
    {
        return gridSize;
    }

    // consider setting own color in Update()

    public Vector2Int GetGridPos()
    {
        return new Vector2Int(
            Mathf.RoundToInt(transform.position.x / 10f),
            Mathf.RoundToInt(transform.position.z / 10f)
        );
    }

    public void SetTopColor(Color color)
    {
        MeshRenderer topMeshRenderer = transform.Find("Top").GetComponent<MeshRenderer>();
        topMeshRenderer.material.color = color;
    }
}
