using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Exceptions {
    public class GridFullException : System.Exception {
        public GridFullException(string message) : base(message) {
            // do nothing
        }
    }
}