using System;
using System.Linq;
using CozyDesigner.Card;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace CozyDesigner.Game
{
    public class Card : MonoBehaviour
    {
        [Header("References")] 
        [SerializeField] Image _borderImage;
        [SerializeField] Image _iconBackgroundImage;
        [SerializeField] Image _iconImage;
        [SerializeField] TMP_Text _titleTextbox;
        [SerializeField] TMP_Text _comfortTextbox;
        [SerializeField] TMP_Text _aestheticTextbox;
        [SerializeField] TMP_Text _durabilityTextbox;
        [Header("Icon + Item Type pair")]
        [SerializeField] CardIcon[] _cardIcons;

        Item _item;

        public void SetItem(Item item)
        {
            _item = item;

            UpdateRarityColor();
            SetIcon();
            SetTitle();
            SetStats();
        }

        void UpdateRarityColor()
        {
            Color color = Color.black;
            switch (_item.itemRarity)
            {
                case ItemRarity.BASIC:
                    color = Color.white;
                    break;
                case ItemRarity.COOL:
                    color = Color.green;
                    break;
                case ItemRarity.LEGENDARY:
                    color = Color.blue;
                    break;
            }
            _borderImage.color = color;
            _iconBackgroundImage.color = color;
        }

        void SetIcon()
        {
            CardIcon cardIcon = _cardIcons.FirstOrDefault(x => x.ItemType == _item.itemType);

            if(cardIcon != null) 
                _iconImage.sprite = cardIcon.IconSprite;
        }

        void SetTitle()
        {
            _titleTextbox.text = _item.name;
        }

        void SetStats()
        {
            _comfortTextbox.text = _item.comfort >= 0 ? 
                $"<color=\"green\">+{_item.comfort}</color>" : $"<color=\"red\">-{_item.comfort}</color>";

            _aestheticTextbox.text = _item.aesthetic >= 0 ?
                $"<color=\"green\">+{_item.aesthetic}</color>" : $"<color=\"red\">-{_item.aesthetic}</color>";

            _durabilityTextbox.text = _item.durability >= 0 ?
                $"<color=\"green\">+{_item.durability}</color>" : $"<color=\"red\">-{_item.durability}</color>";
        }

    }

        [Serializable]
    public class CardIcon
    {
        public Sprite IconSprite;
        public ItemType ItemType;
    }
}
