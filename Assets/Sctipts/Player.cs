using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Camp
{

    public class Player : MonoBehaviour
    {

        private float life;
        public Item item = null;

        void Start()
        {
            item = null;
            life = Manager.MaxLife;

            Manager.player = this;
        }

        void Update()
        {
            if (Input.GetKeyUp(KeyCode.R))
            {
                if (item != null)
                {
                    item.Release(transform.position);
                    item = null;
                }
            }
        }

        void OnTriggerEnter(Collider t) {

            GameObject o = t.gameObject;
            if (o.tag == "Item") {
                if (item == null) {
                    item = t.gameObject.GetComponent<Item>();
                    item.Catch();
                }
            }


}
    }
}