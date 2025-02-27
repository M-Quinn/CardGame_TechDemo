using System;
using UnityEngine;
using Random = UnityEngine.Random;

namespace CozyDesigner.Card
{
    public class Test : MonoBehaviour
    {
        [SerializeField] private GameObject prefab;
        void Start()
        {
            Item chair = new Couch();
            chair = new Moldy(chair);
            chair = new Basic(chair);
            Debug.Log($"{chair.name}\nComfort: {chair.comfort}\nEsthetic: {chair.aesthetic}\nDurability: {chair.durability}\nRarity: {chair.itemRarity}\nType: {chair.itemType}");

            CardCreator cardCreator = new();

            Item randomCard = cardCreator.BuildCard();

            Debug.Log($"{randomCard.name}\nComfort: {randomCard.comfort}\nEsthetic: {randomCard.aesthetic}\nDurability: {randomCard.durability}\nRarity: {randomCard.itemRarity}\nType: {randomCard.itemType}");

            GameObject cardCanvasGO = Instantiate(prefab);
            Game.Card card = cardCanvasGO.GetComponentInChildren<Game.Card>();

            card.SetItem(randomCard);

        }

        
    }
}
