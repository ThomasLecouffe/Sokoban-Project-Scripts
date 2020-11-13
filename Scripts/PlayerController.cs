using UnityEngine;
using UnityEngine.Tilemaps;

public class PlayerController : MonoBehaviour
{
    public float distanceToMove = 0.98f;
    public Tilemap blocks;
    public Tilemap crates;

    public float offsetX;
    public float offsetY;

    private Vector3 targetPosition;
    private Vector3Int tilemapPosition;
    private Animator animator;
    private GameControllerSokoban gameController;

    // Start is called before the first frame update
    private void Start()
    {
        targetPosition = transform.position;
        tilemapPosition = blocks.WorldToCell(transform.position);
        animator = GetComponent<Animator>(); 
        gameController = GameObject.Find("GameManager").GetComponent<GameControllerSokoban>();
    }

    // Update is called once per frame
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Z)) {
            animator.SetTrigger("Up");
            movePlayer(0);
            moveCrate(0);
        }
        else if(Input.GetKeyDown(KeyCode.Q)) {
            animator.SetTrigger("Left");
            movePlayer(3);
            moveCrate(3);
        }
        else if(Input.GetKeyDown(KeyCode.S)) {
            animator.SetTrigger("Down");
            movePlayer(2);
            moveCrate(2);
        }
        else if(Input.GetKeyDown(KeyCode.D)) {
            animator.SetTrigger("Right");
            movePlayer(1);
            moveCrate(1);
        }
    }

    private void movePlayer(int direction) {
        switch (direction) {
            case 0:
                if (!blocks.HasTile(new Vector3Int(tilemapPosition.x, tilemapPosition.y + 1, tilemapPosition.z))) {  
                    targetPosition = new Vector3(targetPosition.x, targetPosition.y + distanceToMove, targetPosition.z);
                }
                break;
            case 1:
                if (!blocks.HasTile(new Vector3Int(tilemapPosition.x + 1, tilemapPosition.y, tilemapPosition.z))) {  
                    targetPosition = new Vector3(targetPosition.x + distanceToMove, targetPosition.y, targetPosition.z);
                }
                break;
            case 2:
                if (!blocks.HasTile(new Vector3Int(tilemapPosition.x, tilemapPosition.y - 1, tilemapPosition.z))) {  
                    targetPosition = new Vector3(targetPosition.x, targetPosition.y - distanceToMove, targetPosition.z);
                }
                break;
            case 3:
                if (!blocks.HasTile(new Vector3Int(tilemapPosition.x - 1, tilemapPosition.y, tilemapPosition.z))) {  
                    targetPosition = new Vector3(targetPosition.x - distanceToMove, targetPosition.y, targetPosition.z);
                }
                break;
        }
    }
    private void moveCrate(int direction) {
        if (crates.HasTile(crates.WorldToCell(targetPosition))) {
            Vector3 offset = Vector3.zero;
            switch (direction) {
                case 0:
                    offset = new Vector3(targetPosition.x, targetPosition.y + 1, targetPosition.z);
                    break;
                case 1:
                    offset = new Vector3(targetPosition.x + 1, targetPosition.y, targetPosition.z);
                    break;
                case 2:
                    offset = new Vector3(targetPosition.x, targetPosition.y - 1, targetPosition.z);
                    break;
                case 3:
                    offset = new Vector3(targetPosition.x - 1, targetPosition.y, targetPosition.z);
                    break;
            }
            if (crates.HasTile(crates.WorldToCell(offset)) || blocks.HasTile(blocks.WorldToCell(offset))) {
                targetPosition = transform.position;

            }
            else {
                TileBase tilebase = crates.GetTile(crates.WorldToCell(targetPosition));
                crates.SetTile(crates.WorldToCell(offset), tilebase);
                crates.SetTile(crates.WorldToCell(targetPosition), null);
            }
        }
        gameController.checkWin();
    }

    private void FixedUpdate() {
        transform.position = targetPosition;
        tilemapPosition = blocks.WorldToCell(transform.position);
    }

    public void setPosition(Vector3 position)
    {
        targetPosition = position;
        targetPosition.x += offsetX;
        targetPosition.y += offsetY;

    }
}
