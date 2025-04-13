using System.Collections.Generic;
using System.Linq;
using LockKitty;
using UnityEngine;

namespace Controller
{
    public class CatsDataController : MonoBehaviour
    {
        private CatsData _catsData;
        private DataStorage _dataStorage;

        private void Awake()
        {
            _dataStorage = new DataStorage();
            _catsData = _dataStorage.LoadData();
        }

        public CatsData GetCatsData()
        {
            return _catsData;
        }

        public List<Section> GetSections()
        {
            return _catsData.Sections;
        }

        public List<CatButton> GetButtons(string id)
        {
            return _catsData.Sections.FirstOrDefault(s => s.Id == id).Items;
        }

        public void AddSelection(Section section)
        {
            _catsData.Sections.Add(section);
            SaveData();
        }

        public Section GetSection(Section section)
        {
            return _catsData.Sections.FirstOrDefault(s => s.Id == section.Id);
        }

        public void RemoveSelection(Section section)
        {
            if (_catsData.Sections.FirstOrDefault(s => s.Id == section.Id) != null)
            {
                _catsData.Sections.Remove(section);
                SaveData();
            }
            else
            {
                Debug.LogError("Section not found");
            }
        }

        private void SaveData()
        {
            _dataStorage.SaveData(_catsData);
        }
    }
}