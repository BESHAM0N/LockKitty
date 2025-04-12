using System;
using System.IO;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;

namespace LockKitty
{
    public static class DataStorage
    {
        private static readonly string _fileName = "data.json";
        private static string _filePath => Path.Combine(Application.persistentDataPath, _fileName);

        /// <summary>
        /// Сохраняет данные в файл.
        /// </summary>
        /// <param name="data">Объект CredentialData, содержащий все разделы и записи.</param>
        public static void SaveData(CredentialData data)
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
        public static CredentialData LoadData()
        {
            if (!File.Exists(_filePath))
            {
                Debug.Log("Data file not found. Creating new credential data.");
                return new CredentialData { Sections = new List<Section>() };
            }
        
            try
            {
                var json = File.ReadAllText(_filePath);
                var data = JsonConvert.DeserializeObject<CredentialData>(json);
                return data ?? new CredentialData { Sections = new List<Section>() };
            }
            catch (Exception ex)
            {
                Debug.LogError("Error loading data: " + ex.Message);
                return new CredentialData { Sections = new List<Section>() };
            }
        }
    }
}
