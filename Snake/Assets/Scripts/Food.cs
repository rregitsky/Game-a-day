using UnityEngine;

namespace Assets.Scripts {
    public class Food {
        public Vector2Int Position { get; set; }

        public Food(Vector2Int position) {
            this.Position = position;
        }

    }
}