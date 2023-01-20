using UnityEngine;
using System.Collections.Generic;

namespace Assets.Scripts {
    public class Snake {
        public int Length { get; private set; } = 1;
        public Vector2Int MoveDirection { get; set; } = Vector2Int.right;
        public float Speed { get; set; } = 1f;
        public Vector2Int Position { get { return headPosition; }  }
        private Vector2Int headPosition;
        private Queue<Vector2Int> positionHistory;

        public Snake(Vector2Int startPosition) {
            this.headPosition = startPosition;
            positionHistory = new Queue<Vector2Int>(10);
        }

        public Vector2Int[] GetPositionHistory() {
            return this.positionHistory.ToArray();
        }

        public void MoveTo(Vector2Int newPosition) {
            this.positionHistory.Enqueue(this.headPosition);
            this.headPosition = newPosition;
        }

        public void IncrementLength() {
            this.Length++;
        }
    }
}