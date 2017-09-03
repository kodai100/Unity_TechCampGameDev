using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Camp {

    public class ItemPasta : Item {

        public float life = 100;
        public float speed = 0.01f;
        public bool released;

        void Start() {
            itemCategory = ItemCategory.Pasta;
        }

        void Update() {
            if (catched && released)
            {
                life -= speed;
            }

            if (life < 0)
            {
                Destroy(gameObject);
            }
        }

        public override void Catch()
        {
            if (!catched)
            {
                gameObject.SetActive(false);
                catched = true;
            }
            
        }

        public override void Release(Vector3 position)
        {
            transform.SetPositionAndRotation(position, Quaternion.identity);
            gameObject.SetActive(true);
            Manager.AddActiveItemList(this);
            released = true;
        }
    }
}