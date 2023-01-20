using UnityEngine;
using Assets.Scripts;
using Assets.Scripts.Exceptions;

public class GameManager : MonoBehaviour {
    GameObject snakePiecePrefab;
    GameObject foodPrfab;
    Snake snake;
    Food food;
    Assets.Scripts.Grid grid;

    // Start is called before the first frame update
    void Start() {
        grid = new Assets.Scripts.Grid(18, 24);
        snake = new Snake(new Vector2Int(grid.Rows / 2, grid.Columns / 2));
        food = new Food(grid.GetRandomEmptyCell());
    }

    // Update is called once per frame
    void Update() {
        // Get input


        // Check snake/food collision
        if(snake.Position == food.Position) {
            snake.IncrementLength();
            food.Position = grid.GetRandomEmptyCell();
        }
        
        // Lastly update all game objects
    }

    private Vector2Int getDirectionFromInput() {
        Vector2Int direction = snake.MoveDirection;
        if(Input.GetKey("up")) {
            direction = Vector2Int.up;
        }
        if(Input.GetKey("down")) {

        }
        if(Input.GetKey("right")) {

        }
        if(Input.GetKey("left")) {

        }
