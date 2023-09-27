using UnityEngine;

namespace Runtime.Data.ValueObjects
{

    [SerializeField]
    //[System.Serializable]
    public struct InputData
    {
        public float HorizontalInputSpeed;
        public Vector2 ClampValues;
        public float ClampSpeed;
    }

}

