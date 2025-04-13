using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace View
{
    public sealed class CatButtonView : MonoBehaviour
    {
        [SerializeField] private Button _button;
        [SerializeField] private Image _image;
        [SerializeField] private TMP_Text _text;

        public void Set(string text, Color color)
        {
            _text.text = text;
            _image.color = color;
        }
    }
}