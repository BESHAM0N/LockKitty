using UnityEngine;
using Services;
using TMPro;

namespace View
{
    public sealed class SectionView : MonoBehaviour
    {
        [SerializeField] private TMP_Text _title;
        [SerializeField] private Transform _content;
        
        private void OnEnable()
        {
            Observer.OnSectionChanged += UpdateSectionList;
        }

        private void OnDisable()
        {
            Observer.OnSectionChanged -= UpdateSectionList;
        }

        private void UpdateSectionList()
        {
            //TODO: Здесь разместите логику обновления списка разделов на интерфейсе.
            Debug.Log("Section list updated due to model change.");
        }

        private void Set(string title)
        {
            _title.text = title;
        }
    }
}