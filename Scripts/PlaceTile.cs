using UnityEngine;
using UnityEngine.Tilemaps;

public class PlaceTile : MonoBehaviour
{

    public Tilemap tileMap;
    // Start is called before the first frame update
    void Start()
    {
        TileBase tilebase = tileMap.GetTile(tileMap.WorldToCell(new Vector3(-2,-4,0)));
        tileMap.SetTile(tileMap.WorldToCell(new Vector3(-3,-2,0)), tilebase);
    }
}
