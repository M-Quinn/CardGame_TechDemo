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

            var values = Enum.GetValues(typeof(ItemAdjective));
            ItemAdjective randAdjective = (ItemAdjective) values.GetValue(Random.Range(0, values.Length));

            Debug.Log(randAdjective);
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
