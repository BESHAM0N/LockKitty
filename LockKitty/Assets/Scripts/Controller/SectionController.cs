using System;
using LockKitty;
using UnityEngine;

namespace Controller
{
    public sealed class SectionController : MonoBehaviour
    {
        [SerializeField] private CatsDataController _catsDataController;

        public void AddSection(string sectionTitle)
        {
            var newSection = new Section
            {
                Id = Guid.NewGuid().ToString(),
                SectionTitle = sectionTitle,
                Items = new System.Collections.Generic.List<CatButton>()
            };
            
            _catsDataController.AddSelection(newSection);
        }

        public void RemoveSection(Section section)
        {
            _catsDataController.RemoveSelection(section);
        }
    }
}