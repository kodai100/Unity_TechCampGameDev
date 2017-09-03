using System.Collections.Generic;
using UnityEngine;

namespace Camp {

    public class Manager : SingletonMonoBehaviour<Manager> {

        public static bool GameStart;
        public static bool GameEnd;
        public static Player player;

        public static List<Item> currentActiveItems = new List<Item>();

        // GameData
        public static float MaxLife = 100;
        public static float TimeLimit = 60 * 3;


        
        void Start() {

        }
        
        void Update() {
            if (GameStart)
            {
                Debug.Log("Start");
            }

            Debug.Log(currentActiveItems.Count);
        }

        public static void AddActiveItemList(Item item)
        {
            currentActiveItems.Add(item);
        }
        public static void RemoveActiveItemList(Item item)
        {
            currentActiveItems.Remove(item);
        }

        public void OnGameStart() {
            GameStart = true;
        }

    }

}