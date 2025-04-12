using UnityEngine;
using Services;

namespace View
{
    public sealed class SectionView : MonoBehaviour
    {
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
    }
}