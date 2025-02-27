using UnityEngine;

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
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
