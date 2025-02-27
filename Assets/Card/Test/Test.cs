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

            Item randomCard = BuildCard();

            Debug.Log($"{randomCard.name}\nComfort: {randomCard.comfort}\nEsthetic: {randomCard.esthetic}\nDurability: {randomCard.durability}\nRarity: {randomCard.itemRarity}\nType: {randomCard.itemType}");
        }

        Item BuildCard()
        {
            var valuesAdj = Enum.GetValues(typeof(ItemAdjective));
            ItemAdjective randAdjective = (ItemAdjective)valuesAdj.GetValue(Random.Range(0, valuesAdj.Length));

            var valuesItem = Enum.GetValues(typeof(ItemType));
            ItemType randItem = (ItemType)valuesItem.GetValue(Random.Range(0, valuesItem.Length));

            var valuesRarity = Enum.GetValues(typeof(ItemRarity));
            ItemRarity randRarity = (ItemRarity)valuesRarity.GetValue(Random.Range(0, valuesRarity.Length));


            Item item;

            switch (randItem)
            {
                case ItemType.CHAIR:
                    item = new Chair();
                    break;
                case ItemType.COUCH:
                    item = new Couch();
                    break;
                case ItemType.TABLE:
                    item = new Table();
                    break;
                case ItemType.DESK:
                    item = new Desk();
                    break;
                case ItemType.BED:
                    item = new Bed();
                    break;
                default:
                    item = new Chair();
                    Debug.LogError($"Item type {randItem} failed");
                    break;
            }

            switch (randAdjective)
            {
                case ItemAdjective.NONE:
                    break;
                case ItemAdjective.MOLDY:
                    item = new Moldy(item);
                    break;
                case ItemAdjective.RIPPED:
                    item = new Ripped(item);
                    break;
                case ItemAdjective.LEATHER:
                    item = new Leather(item);
                    break;
                case ItemAdjective.REINFORCED:
                    item = new Reinforced(item);
                    break;
                case ItemAdjective.WOODEN:
                    item = new Wooden(item);
                    break;
                case ItemAdjective.METAL:
                    item = new Metal(item);
                    break;
            }

            switch (randRarity)
            {
                case ItemRarity.BASIC:
                    item = new Basic(item);
                    break;
                case ItemRarity.COOL:
                    item = new Cool(item);
                    break;
                case ItemRarity.LEGENDARY:
                    item = new Legendary(item);
                    break;
            }

            return item;
        }
    }
}
