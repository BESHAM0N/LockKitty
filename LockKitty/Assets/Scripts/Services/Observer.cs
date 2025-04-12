using System;

namespace Services
{
    public class Observer
    {
        // Событие, вызываемое при изменении данных (например, добавлен новый раздел или запись, удаление, обновление)
        public static event Action OnCredentialDataChanged;

        // Событие для обновления списка разделов
        public static event Action OnSectionChanged;

        // Событие для обновления конкретной записи
        public static event Action OnCredentialItemChanged;

        // Метод для вызова события изменения CredentialData
        public static void RaiseCredentialDataChanged()
        {
            OnCredentialDataChanged?.Invoke();
        }
        
        // Метод для вызова события изменения разделов
        public static void RaiseSectionChanged()
        {
            OnSectionChanged?.Invoke();
        }
        
        // Метод для вызова события изменения записи
        public static void RaiseCredentialItemChanged()
        {
            OnCredentialItemChanged?.Invoke();
        }
    }
}