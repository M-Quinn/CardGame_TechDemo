using System;
using UnityEngine;
using Random = UnityEngine.Random;

namespace CozyDesigner.Card
{
    public class Test : MonoBehaviour
    {
        
        void Start()
        {
            Item chair = new Chair();
            chair = new Moldy(chair);
            chair = new Basic(chair);
            Debug.Log($"{chair.name}\nComfort: {chair.comfort}\nEsthetic: {chair.esthetic}\nDurability: {chair.durability}\nRarity: {chair.itemRarity}\nType: {chair.itemType}");

            CardCreator cardCreator = new();

            Item randomCard = cardCreator.BuildCard();

            Debug.Log($"{randomCard.name}\nComfort: {randomCard.comfort}\nEsthetic: {randomCard.esthetic}\nDurability: {randomCard.durability}\nRarity: {randomCard.itemRarity}\nType: {randomCard.itemType}");
        }

        
    }
}
