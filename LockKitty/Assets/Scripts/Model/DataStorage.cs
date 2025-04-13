using System;
using System.IO;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;

namespace LockKitty
{
    public sealed class DataStorage
    {
        private static readonly string _fileName = "data.json";
        private static string _filePath => Path.Combine(Application.persistentDataPath, _fileName);

        /// <summary>
        /// Сохраняет данные в файл.
        /// </summary>
        /// <param name="data">Объект CredentialData, содержащий все разделы и записи.</param>
        public void SaveData(CatsData data)
        {
            try
            { 
                var json = JsonConvert.SerializeObject(data, Formatting.Indented);
               File.WriteAllText(_filePath, json);
                
                Debug.Log("Data saved successfully: " + _filePath);
            }
            catch (Exception ex)
            {
                Debug.LogError("Error saving data: " + ex.Message);
            }
        }

        /// <summary>
        /// Загружает данные из файла.
        /// </summary>
        /// <returns>Объект CredentialData, содержащий разделы и записи. Если файла нет, возвращается новый объект.</returns>
        public CatsData LoadData()
        {
            if (!File.Exists(_filePath))
            {
                Debug.Log("Data file not found. Creating new credential data.");
                return new CatsData { Sections = new List<Section>() };
            }
        
            try
            {
                var json = File.ReadAllText(_filePath);
                var data = JsonConvert.DeserializeObject<CatsData>(json);
                return data ?? new CatsData { Sections = new List<Section>() };
            }
            catch (Exception ex)
            {
                Debug.LogError("Error loading data: " + ex.Message);
                return new CatsData { Sections = new List<Section>() };
            }
        }
    }
}
