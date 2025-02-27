using CozyDesigner.Card;
using CozyDesigner.Game;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] Transform _cardSpawnParent;
    [SerializeField] GameObject _cardPrefab;

    CardCreator _creator = new();

    void Start()
    {
        for (int i = 0; i < 6; i++)
        {
            var GO = Instantiate(_cardPrefab, _cardSpawnParent);
            Card card = GO.GetComponentInChildren<Card>();
            card.SetItem(_creator.BuildCard());
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
