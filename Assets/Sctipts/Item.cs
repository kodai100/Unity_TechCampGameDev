using UnityEngine;

namespace Camp
{

    public enum ItemCategory
    {
        Camera, Pasta
    }

    public abstract class Item : MonoBehaviour
    {

        protected ItemCategory itemCategory;
        public bool catched;

        private void OnEnable()
        {
            
        }

        void Start()
        {

        }

        void Update()
        {
        }

        private void OnDestroy()
        {
            Manager.RemoveActiveItemList(this);
            Debug.Log("Deleted");
        }

        public abstract void Catch();
        public abstract void Release(Vector3 position);
    }
}