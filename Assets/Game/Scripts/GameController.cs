using CozyDesigner.Card;
using CozyDesigner.Game;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    [SerializeField] Transform _cardSpawnParent;
    [SerializeField] GameObject _cardPrefab;
    [SerializeField] Button _button;

    CardCreator _creator = new();

    void Start()
    {
        RefreshDeck();
    }

    void OnEnable() => _button.onClick.AddListener(RefreshDeck);
    void OnDisable() => _button.onClick.RemoveListener(RefreshDeck);

    void RefreshDeck()
    {
        RemoveDeck();
        BuildDeck();
    }

    void RemoveDeck()
    {
        while (_cardSpawnParent.childCount > 0)
        {
            DestroyImmediate(_cardSpawnParent.GetChild(0).gameObject);
        }
    }

    void BuildDeck()
    {
        for (int i = 0; i < 6; i++)
        {
            var GO = Instantiate(_cardPrefab, _cardSpawnParent);
            Card card = GO.GetComponentInChildren<Card>();
            card.SetItem(_creator.BuildCard());
        }
    }
}
