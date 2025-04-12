using System;
using LockKitty;
using Services;
using UnityEngine;

namespace Controller
{
    public sealed class SectionController : MonoBehaviour
    {
        private CredentialData credentialData;

        private void Awake()
        {
            credentialData = DataStorage.LoadData();
        }

        public void AddSection(string sectionTitle)
        {
            var newSection = new Section
            {
                Id = Guid.NewGuid().ToString(),
                SectionTitle = sectionTitle,
                Items = new System.Collections.Generic.List<CredentialItem>()
            };

            credentialData.Sections.Add(newSection);
            
            DataStorage.SaveData(credentialData);
            Observer.RaiseSectionChanged();
            Observer.RaiseCredentialDataChanged();
        }

        public void RemoveSection(Section section)
        {
            if (credentialData.Sections.Contains(section))
            {
                credentialData.Sections.Remove(section);
                DataStorage.SaveData(credentialData);
                Observer.RaiseSectionChanged();
                Observer.RaiseCredentialDataChanged();
            }
            else
            {
                Debug.LogWarning("Section not found.");
            }
        }
    }
}